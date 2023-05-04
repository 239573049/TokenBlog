import React, { Component } from 'react'
import MonacoEditor from 'react-monaco-editor';
import './index.css';
import { Button, Card } from '@douyinfe/semi-ui';
import { request } from 'http';

declare let BrotliDecode: any;
declare let DotNet: any;
declare let Blazor: any;

export default class Ide extends Component {

    state = {
        code: 'Console.WriteLine("你好，世界！");',
        first: true,
        result: ''
    }

    constructor(props: any) {
        super(props);
        this.editorDidMount = this.editorDidMount.bind(this);
        this.onChange = this.onChange.bind(this);
    }

    async editorDidMount(editor: { focus: () => void; }, monaco: any) {
        console.log('editorDidMount', editor);
        editor.focus();
    }

    onChange(newValue: any, e: any) {
        console.log('onChange', newValue, e);
    }

    async onRun() {
        var { code } = this.state;
        await this.execute(code);
    }

    async execute(code: any) {
        var { result, first } = this.state;

        if (first) {
            Blazor.start({
                loadBootResource: function (type: string, name: any, defaultUri: string, integrity: any) {
                    // 注意：这里使用localhost的时候不会启动压缩
                    if (type !== 'dotnetjs') {
                        return (async function () {
                            const response = await fetch('https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/' + defaultUri + '.br', { cache: 'no-cache' });
                            if (!response.ok) {
                                throw new Error(response.statusText);
                            }
                            const originalResponseBuffer = await response.arrayBuffer();
                            const originalResponseArray = new Int8Array(originalResponseBuffer);
                            const decompressedResponseArray = BrotliDecode(originalResponseArray);
                            const contentType = type ===
                                'dotnetwasm' ? 'application/wasm' : 'application/octet-stream';
                            return new Response(decompressedResponseArray,
                                { headers: { 'content-type': contentType } });
                        })();
                    }
                },
            }).then(async () => {
                await DotNet.invokeMethodAsync('WebEditor', 'Init', 'https://token-web-ide.oss-cn-shenzhen.aliyuncs.com');
                // 使用js互操调用WebEditor程序集下的Execute静态方法，并且发送参数
                result = await DotNet.invokeMethodAsync('WebEditor', 'Execute', code);
                this.setState({
                    result
                })
            });
            this.setState({
                first: false
            })
        } else {
            // 使用js互操调用WebEditor程序集下的Execute静态方法，并且发送参数
            result = await DotNet.invokeMethodAsync('WebEditor', 'Execute', code);
            this.setState({
                result
            })
        }

    }

    render() {
        var { code, result } = this.state;
        const options = {
            automaticLayout: false,
        };

        return (
            <>
                <div className="container">
                    <div className="editor">
                        <MonacoEditor
                            language="json"
                            theme="vs-dark"
                            value={code}
                            options={options}
                            onChange={(e) => this.setState({
                                code: e
                            })}
                            editorDidMount={this.editorDidMount}
                        />
                    </div>
                    <div className="info">
                        <div className="buttons">
                            <Button theme='borderless' className="clear" onClick={() => this.setState({
                                result: ''
                            })}>清空</Button>
                            <Button theme='borderless' className="run" onClick={async () => await this.onRun()}>执行代码</Button>
                        </div>
                        <div className="output">
                            {result}
                        </div>
                    </div>
                </div></>
        )
    }
}
