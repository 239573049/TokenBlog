import { Pagination } from '@douyinfe/semi-ui';
import { Component } from 'react'
import { FailarmyDto } from '../../../models/blogger';
import { FailarmyService } from '../../../services/failarmyService';

interface IProps {

}

interface IState {
  data: {
    total: number,
    result: FailarmyDto[]
  },
  input: {
    keyword: string;
    page: number;
    pageSize: number;
  }
}
export default class Compilations extends Component<IProps, IState> {

  state: Readonly<IState> = {
    input: {
      keyword: '',
      page: 1,
      pageSize: 10
    },
    data: {
      total: 0,
      result: []
    }
  }


  LoadList() {
    const { input } = this.state;
    FailarmyService
      .getList(input.keyword, input.page, input.pageSize)
      .then(x => {
        this.setState({
          data: x
        })
      })
  }

  componentDidMount(): void {
    this.LoadList();
  }

  render() {
    var { input, data } = this.state;
    return (
      <><div style={{ maxHeight: 'calc(100vh - 240px)', overflow: 'auto' }}>
        <div className='article'>
          {data.result.map((x, i) => {
            return (
              <>
                <div onClick={() => {

                }} style={{ margin: '5px' }}>
                  <div className='blog-img' style={{ backgroundImage: x.background }}>
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
                      {x.name}
                    </div>
                    <div style={{ marginTop: '25px', position: 'relative' }}>
                    </div>
                    <div className={"blog-article-content " + x.show ? "blog-article-content-select" : ""}>
                      <div style={{ margin: '10px' }}>
                        <div style={{ fontSize: '10px' }}>{x.description}</div>
                        <div>篇章：{x.count}</div>
                      </div>
                    </div>
                  </div>
                </div>
              </>
            )
          })}

        </div>
      </div>
        <Pagination total={data.total} showTotal onChange={(e) => {
          input.page = e;
          this.setState({ input }, () => {
            this.LoadList();
          })
        }} defaultCurrentPage={input.page}></Pagination>
      </>
    )
  }
}
