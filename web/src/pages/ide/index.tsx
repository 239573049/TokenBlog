import React, { Component } from 'react'
import MonacoEditor from 'react-monaco-editor';
import './index.css';
import { Button, Card } from '@douyinfe/semi-ui';
import { request } from 'http';
import { DotentUtil } from '../../utils/dotnetUtil';

declare let BrotliDecode: any;
declare let DotNet: any;
declare let Blazor: any;

export default class Ide extends Component {

    state = {
        code: 'Console.WriteLine("你好，世界！");',
        first: true,
        result: '',
        assemblys: [
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Buffers.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Collections.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Core.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Linq.Expressions.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Linq.Parallel.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/mscorlib.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Linq.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Console.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Runtime.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Net.Http.dll",
            "https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/assembly/System.Console.dll"]
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
        var { result, first, assemblys } = this.state;

        if (first) {
            Blazor.start({
                // loadBootResource: function (type: string, name: any, defaultUri: string, integrity: any) {
                //     if (type !== 'dotnetjs') {
                //         return (async function () {
                //             const response = await fetch('https://token-web-ide.oss-cn-shenzhen.aliyuncs.com/' + defaultUri + '.br', { cache: 'no-cache' });
                //             if (!response.ok) {
                //                 throw new Error(response.statusText);
                //             }
                //             const originalResponseBuffer = await response.arrayBuffer();
                //             const originalResponseArray = new Int8Array(originalResponseBuffer);
                //             const decompressedResponseArray = BrotliDecode(originalResponseArray);
                //             const contentType = type ===
                //                 'dotnetwasm' ? 'application/wasm' : 'application/octet-stream';
                //             return new Response(decompressedResponseArray,
                //                 { headers: { 'content-type': contentType } });
                //         })();
                //     } 
                // },
            }).then(async () => {
                // 首次初始化
                await DotentUtil.Init('https://token-web-ide.oss-cn-shenzhen.aliyuncs.com');

                // 首次加载程序集
                await DotentUtil.LoadAssembly(assemblys);

                // 使用js互操调用WebEditor程序集下的Execute静态方法，并且发送参数
                result = await DotentUtil.Execute(code);
                this.setState({
                    result
                })
            });
            this.setState({
                first: false
            })
        } else {
            // 使用js互操调用WebEditor程序集下的Execute静态方法，并且发送参数
            result = await DotentUtil.Execute(code);
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
