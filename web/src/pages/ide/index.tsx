import React, { Component } from 'react'
import MonacoEditor from 'react-monaco-editor';
import './index.css';
import { Button, Card } from '@douyinfe/semi-ui';
import { request } from 'http';

declare var DotNet: any;

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
        var { result } = this.state;
        await DotNet.invokeMethodAsync('WebEditor', 'Init', 'https://token-web-ide.oss-cn-shenzhen.aliyuncs.com');

        // 使用js互操调用WebEditor程序集下的Execute静态方法，并且发送参数
        result = await DotNet.invokeMethodAsync('WebEditor', 'Execute', code);
        this.setState({
            result
        })
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
                            <Button theme='borderless' className="clear" onClick={()=>this.setState({
                                result:''
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
