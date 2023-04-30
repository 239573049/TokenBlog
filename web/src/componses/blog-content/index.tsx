import { Component } from 'react'
import './index.css'
import { Row, Col, Card, Avatar, Divider, Collapse } from '@douyinfe/semi-ui'
import { IconHome, IconAppCenter,IconGithubLogo,IconBranch } from '@douyinfe/semi-icons';
import { Outlet, Link } from "react-router-dom";

export default class BlogContent extends Component {

    state = {
        category: [
            {
                "name": ".NET",
                "path": '/dotnet'
            },
            {
                "name": "React",
                "path": '/react'
            }
        ]
    }

    render() {
        var pathname = window.location.pathname;
        var { category } = this.state;
        return (
            <div className='blog-content'>
                <Row style={{ height: '100%' }}>
                    <Col span={4} style={{ height: '100%' }}>
                        <Card style={{ height: '100%' }}>
                            <div style={{ height: '100px' }}>
                                <Avatar style={{ backgroundColor: '#87d068', margin: 4 }} alt='Youself Zhang'>YZ</Avatar>
                                <span >Token AI</span>
                            </div>
                            <span style={{ fontSize: '12px', color: '#98a6ad!important' }}>导航</span>
                            <div style={{ margin: '5px' }}>
                                <Link className={"menu " + (pathname === "/" ? "menu-select" : "")} onClick={() => {
                                    this.setState({
                                        pathname: '/'
                                    })
                                }} to={'/'}>
                                    <IconHome style={{ margin: '3px' }} />
                                    <span>首页</span>
                                </Link>
                                <Link className={"menu " + (pathname === "/links" ? "menu-select" : "")} onClick={() => {
                                    this.setState({
                                        pathname: '/links'
                                    })
                                }} to={'/links'}>
                                    <IconBranch  style={{ margin: '3px' }} />
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
                                            <Link to={x.path} className={"menu " + (pathname === x.path ? "menu-select" : "")} onClick={() => {
                                                this.setState({
                                                    pathname: x.path
                                                })
                                            }}>
                                                <span>{x.name}</span>
                                            </Link>
                                        )
                                    })}
                                </Collapse.Panel>
                            </Collapse>
                        </Card>
                    </Col>
                    <Col span={16}>
                        <div className="col-content">
                            <Outlet />
                        </div>
                    </Col>
                    <Col span={4}><div className="col-content">col-8</div></Col>
                </Row>
            </div>
        )
    }
}
