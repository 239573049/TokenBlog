import { Component } from 'react'
import './index.css'
import { Row, Col, Card, Avatar, Divider, Collapse, Tag, Space, Pagination } from '@douyinfe/semi-ui'
import { IconHome, IconAppCenter, IconGithubLogo, IconBranch } from '@douyinfe/semi-icons';
import { Outlet, Link } from "react-router-dom";
import { PathEvent } from '../events/pathEvent';
import { TabService } from '../../services/tabService';
import { CategoryDto, TabDto } from '../../models/blogger';
import { TagColor } from '@douyinfe/semi-ui/lib/es/tag';
import { CategoryService } from '../../services/categoryService';
import Ranking from '../ranking';

export default class BlogContent extends Component {

    state = {
        tab: [] as TabDto[],
        category: [
        ] as CategoryDto[]
    }

    getTabs() {
        TabService.getTabs()
            .then(res => {
                this.setState({
                    tab: res
                })
            })
    }

    getCategory() {
        CategoryService.getList()
            .then(res => {
                this.setState({
                    category: res
                })
            })
    }

    componentDidMount(): void {
        this.getTabs();
        this.getCategory();
    }

    render() {
        var pathname = window.location.pathname;
        var { category, tab } = this.state;
        let count = 0;
        category.forEach(x => {
            count += x.count;
        })
        var colors = ['amber', 'blue', 'cyan', 'green', 'grey', 'indigo',
            'light-blue', 'light-green', 'lime', 'orange', 'pink',
            'purple', 'red', 'teal', 'violet', 'yellow', 'white'
        ] as TagColor[];
        return (
            <div className='blog-content'>
                <Row style={{ height: '100%' }}>

                    <Col span={4} style={{ height: '100%' }}>
                        <Card style={{ height: '100%' }}>
                            <div onClick={() => window.open('https://github.com/239573049')} style={{ height: '100px' }}>
                                <Card
                                    shadows='hover'
                                    bodyStyle={{
                                        display: 'flex',
                                        alignItems: 'center',
                                        justifyContent: 'space-between'
                                    }}>
                                    <Avatar style={{ backgroundColor: '#87d068', margin: 4 }} src='/AI.png'></Avatar>
                                    <span >Token</span>
                                </Card>
                            </div>
                            <span style={{ fontSize: '12px', color: '#98a6ad!important' }}>导航</span>
                            <div style={{ margin: '5px' }}>
                                <Link className={"menu " + (pathname === "/" ? "menu-select" : "")} onClick={() => {
                                    this.setState({
                                        pathname: '/'
                                    })
                                    PathEvent.emit('blog-path', {
                                        deleteid: 'true',
                                    })
                                }} to={'/'}>
                                    <IconHome style={{ margin: '3px' }} />
                                    <span>首页({count})</span>
                                </Link>
                                <Link className={"menu " + (pathname === "/links" ? "menu-select" : "")} onClick={() => {
                                    this.setState({
                                        pathname: '/links'
                                    })
                                }} to={'/links'}>
                                    <IconBranch style={{ margin: '3px' }} />
                                    <span>友链</span>
                                </Link >
                                <Link to='/repository' className={"menu " + (pathname === "/repository" ? "menu-select" : "")} onClick={() => {
                                    this.setState({
                                        pathname: '/repository'
                                    })
                                }}>
                                    <IconGithubLogo style={{ margin: '3px' }} />
                                    <span>仓库</span>
                                </Link>
                            </div>
                            <Divider margin='12px' />
                            <Collapse>
                                <Collapse.Panel header={<><IconAppCenter />分类</>} itemKey="1">
                                    {category.map(x => {
                                        return (
                                            <Link to={"/?type=" + x.id} className={"menu " + (pathname === x.id ? "menu-select" : "")} onClick={() => {
                                                this.setState({
                                                    pathname: x.id
                                                })
                                                PathEvent.emit('blog-path', {
                                                    id: x.id,
                                                })
                                            }}>
                                                <span>{x.name}</span>
                                                <span style={{ float: 'right' }}>({x.count})</span>
                                            </Link>
                                        )
                                    })}
                                </Collapse.Panel>
                            </Collapse>
                        </Card>
                    </Col>
                    <Col span={16}>
                        <div style={{ marginLeft: '5px', marginRight: '5px' }}>
                            <Card style={{ height: '95px', width: '100%' }}>
                                <h2>南岛鹋</h2>
                                <span>我们没有永恒的朋友，也没有永恒的敌人，只有永恒的利益。</span>
                            </Card>
                        </div>
                        <div style={{ margin: '5px' }}>
                            <Outlet />
                        </div>
                    </Col>
                    <Col span={4} style={{ height: '100%' }}>
                        <Card style={{ height: '100%' }}>
                            <Ranking />
                            <Divider margin='12px' />
                            <span>标签</span>
                            <Divider margin='12px' />
                            <Space wrap>
                                {
                                    tab.map(x => {
                                        return (<Tag onClick={() => {
                                            x.selected = !x.selected;
                                            if (x.selected) {
                                                PathEvent.emit('blog-path', {
                                                    tabId: x.name,
                                                })
                                            } else {
                                                PathEvent.emit('blog-path', {
                                                    deleteTabId: true,
                                                })
                                            }
                                            this.setState({
                                                tab: tab
                                            })
                                        }} color={colors[Math.floor(Math.random() * colors.length)]} key={x.id}>{(x.selected ? "*" : "") + x.name} </Tag>)
                                    })
                                }
                                <Tag onClick={() => {
                                    PathEvent.emit('blog-path', {
                                        deleteTabId: true,
                                    })
                                }} color={colors[Math.floor(Math.random() * colors.length)]} key={99999999}>清空标签</Tag>
                            </Space>
                        </Card>
                    </Col>
                </Row>
            </div>
        )
    }
}
