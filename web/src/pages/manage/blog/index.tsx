import { Button, Card, Form, Select, Tooltip } from '@douyinfe/semi-ui';
import { IconHelpCircle } from '@douyinfe/semi-icons';
import React, { Component } from 'react'
import './index.css'
import { TabService } from '../../../services/tabService';
import { CategoryDto, TabDto } from '../../../models/blogger';
import { CategoryService } from '../../../services/categoryService';

export default class ManageBlog extends Component {

    state = {
        tabs: [] as TabDto[],
        categorys: [] as CategoryDto[]
    }

    loadTabs() {
        TabService.getTabs()
            .then(res => {
                console.log(res);
                
                this.setState({
                    tabs: res
                })
            })
    }

    loadCategorys() {
        CategoryService
            .getList()
            .then(res => {
                this.setState({
                    categorys: res
                })
            })
    }

    componentDidMount(): void {
        this.loadTabs();
        this.loadCategorys();
    }

    render() {
        var { tabs ,categorys} = this.state;
        return (
            <>
                <Card className='search-layout'>

                    <Form labelPosition='left' layout='horizontal' onValueChange={values => console.log(values)}>
                        <Form.Input field='keyword' label='关键字' style={{ width: 150 }} />
                        <Form.Select field="Role" label={{ text: '博客分类', optional: true }} style={{ width: 176 }} >
                            {categorys.map(x => {
                                return (<Select.Option value={x.id}>{x.name}</Select.Option>)
                            })}
                        </Form.Select>
                        <Form.Select field='tabIds' label={{ text: '标签', optional: true }}  multiple style={{ width: '320px' }} >
                            {tabs.map(x => {
                                return (<Select.Option value={x.id}>{x.name}</Select.Option>)
                            })}
                        </Form.Select>
                        <Button type="primary" htmlType="submit" className="btn-margin-right">搜索</Button>
                    </Form>
                </Card>
                <Card className='list-layout'>

                </Card>
            </>
        )
    }
}
