import React, { Component } from 'react'
import { ArticleService } from '../../services/articleService'
import { GetArticleListDto } from '../../models/blogger'
import './index.css'
import { Divider, List, Tooltip } from '@douyinfe/semi-ui'

export default class Ranking extends Component {

    state = {
        data: [] as GetArticleListDto[]
    }

    load() {
        ArticleService
            .getRanking()
            .then(res => {
                this.setState({
                    data: res
                })
            })
    }

    componentDidMount(): void {
        this.load()
    }

    render() {
        var { data } = this.state;
        return (
            <div>
                <div  style={{
                    textAlign: 'center', 
                    fontSize: '12px',background: 'linear-gradient(to bottom, #ff9d00, #ff4e00, #ff0000, #c80000, #960000)'
                }}><span style={{color:"antiquewhite"}}>热榜</span></div>
                <Divider margin='12px'/>
                <div className="list">
                    {data.map((x, i) => {
                        return (
                            <Tooltip
                                position='topLeft'
                                content={x.title + '\r\n访问量:' + x.readCount + '\r\n点赞：' + x.like}>
                                <div onClick={() => {
                                    window.location.href = '/blog?id=' + x.id
                                }} className='list-data' style={{ overflow: 'hidden', textOverflow: 'ellipsis', whiteSpace: 'nowrap' }}>
                                    <span className='list-serial'>{i + 1}.</span>
                                    <span >{x.title}</span>
                                </div>
                            </Tooltip>)
                    })}
                </div>

            </div>
        )
    }
}
