import { Collapse, Pagination, Tag } from '@douyinfe/semi-ui';
import { Component } from 'react'
import { FailarmyDto } from '../../../models/blogger';
import { IconUser } from '@douyinfe/semi-icons';
import { FailarmyService } from '../../../services/failarmyService';
import { formatDate } from '../../../utils/utils';

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
          <Collapse accordion>
            {data.result.map((x, i) => {
              return (
                <Collapse.Panel header={<Tag color='green'> {x.name} </Tag>} itemKey={x.id}>
                  <div className='article'>
                    {x.values.map((x, i) => {
                      return (
                        <>
                          <div onClick={() => {
                            window.location.href = `/blog?id=${x.id}`
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
                                {x.title}
                              </div>
                              <div style={{ marginTop: '65px', position: 'relative' }}>
                              </div>
                              <div className={"blog-article-content " + x.show ? "blog-article-content-select" : ""}>
                                <div style={{ margin: '10px' }}>
                                  <span><IconUser />Token</span> <span>发布于：{formatDate(x.creationTime)}</span> <span>阅读：{x.readCount}</span>
                                </div>
                              </div>
                            </div>
                          </div>
                        </>
                      )
                    })}

                  </div>
                </Collapse.Panel>
              )
            })}
          </Collapse>
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
