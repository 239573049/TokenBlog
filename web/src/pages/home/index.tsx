import React, { Component, useEffect } from 'react'
import PathEvent from '../../componses/events/pathEvent';


interface IProps {

}

interface IState {
  type: string | null
}

var type = new URLSearchParams(window.location.search).get("type");

export default class Home extends Component<IProps, IState> {

  state: Readonly<IState> = {
    type: type
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
    var { type } = this.state;
    return (
      <div>{type}
        1</div>
    )
  }
}
