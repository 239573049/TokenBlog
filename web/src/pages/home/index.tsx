import { Component } from 'react'
import PathEvent from '../../componses/events/pathEvent';
import './index.css'
import { IconUser } from '@douyinfe/semi-icons';

interface IProps {

}

interface IState {
  type: string | null;
  show: boolean;
}

var type = new URLSearchParams(window.location.search).get("type");

export default class Home extends Component<IProps, IState> {

  state: Readonly<IState> = {
    type: type,
    show: false
  }

  componentDidMount(): void {
    // 监听路由变化
    PathEvent.addListener('blog-path', this.handleCustomEvent);
  }

  handleCustomEvent = (event: any) => {
    console.log('====================================');
    console.log(this);
    console.log('====================================');
  }

  componentWillUnmount(): void {
    PathEvent.removeListener('blog-path', this.handleCustomEvent);
  }

  render() {
    var { type, show } = this.state;
    return (
      <div className='article'>
        <div>
          <div className='blog-img'>
          </div>
          <div className='blog-article' onMouseOver={() => {
            this.setState({
              show: true
            })
          }} onMouseOut={() => {
            this.setState({
              show: false
            })
          }}>
            <div className='blog-article-title'>
              来自Token的技术分享
            </div>
            <div className={"blog-article-content " + (show ? "blog-article-content-select" : "")}>
              <div style={{ margin: '10px' }}>
                <span><IconUser />Youself Zhang </span> <span>发布于：2021-01-01</span> <span>阅读：100</span>
              </div>
            </div>
          </div>
        </div>

      </div>
    )
  }
}
