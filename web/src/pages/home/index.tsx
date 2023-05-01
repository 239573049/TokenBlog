import { Component } from 'react'
import { PathEvent } from '../../componses/events/pathEvent';
import './index.css'
import { IconUser } from '@douyinfe/semi-icons';
import { ArticleService } from '../../services/articleService';
import { GetArticleListDto } from '../../models/blogger';
import { formatDate } from '../../utils/utils';

interface IProps {

}

interface IState {
  type: string | null;
  show: boolean;
  data: {
    total: number,
    result: GetArticleListDto[]
  },
  input: {
    keyword: string;
    categoryId: string | null;
    page: number;
    pageSize: number;
  }
}

var type = new URLSearchParams(window.location.search).get("type");

export default class Home extends Component<IProps, IState> {

  state: Readonly<IState> = {
    type: type,
    show: false,
    input: {
      keyword: '',
      categoryId: '',
      page: 1,
      pageSize: 20
    },
    data: {
      total: 0,
      result: []
    }
  }

  componentDidMount(): void {
    this.LoadList();
    // 监听路由变化
    PathEvent.addListener('blog-path', this.handleCustomEvent);
  }

  handleCustomEvent = (event: any) => {
    console.log('====================================');
    console.log(this);
    console.log('====================================');
  }

  LoadList() {
    var { input } = this.state;
    ArticleService
      .getList(input.keyword, input.categoryId, input.page, input.pageSize)
      .then(res => {
        this.setState({
          data: res
        })
      })
  }

  componentWillUnmount(): void {
    PathEvent.removeListener('blog-path', this.handleCustomEvent);
  }

  render() {
    var { type, show, data } = this.state;
    return (
      <div className='article'>
        {data.result.map(x => {
          return (
            <div onClick={() => {
              window.location.href = `/blog?id=${x.id}`
            }} style={{ margin: '5px' }}>
              <div className='blog-img'>
              </div>
              <div className='blog-article' onMouseOver={() => {
                x.show = true;
                this.setState({
                  data: {
                    total: data.total,
                    result: data.result
                  }
                })
              }} onMouseOut={() => {
                x.show = false;
                this.setState({
                  data: {
                    total: data.total,
                    result: data.result
                  }
                })
              }}>
                <div className='blog-article-title'>
                  {x.title}
                </div>
                <div className={"blog-article-content " + (x.show ? "blog-article-content-select" : "")}>
                  <div style={{ margin: '10px' }}>
                    <span><IconUser />Token</span> <span>发布于：{formatDate(x.creationTime)}</span> <span>阅读：{x.readCount}</span>
                  </div>
                </div>
              </div>
            </div>
          )
        })}

      </div>
    )
  }
}
