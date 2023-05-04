import { Avatar, Input, Nav } from '@douyinfe/semi-ui'
import { Component } from 'react'
import {  IconSearch } from '@douyinfe/semi-icons';
import './index.css'
import { PathEvent } from '../events/pathEvent';
import { Link } from 'react-router-dom';

export default class BlogHeader extends Component {

  state = {
    select: false,
    value: ''
  }

  onSearch() {
    var { value } = this.state;
    PathEvent.emit('blog-path', {
      value: value,
    })
  }

  render() {
    var { select, value } = this.state;
    return (
      <div>
        <Nav mode="horizontal" defaultSelectedKeys={['Home']}>
          <Nav.Header>
            <Avatar src='/AI.png'></Avatar>
            Token Blog
          </Nav.Header>
          <Nav.Item>
            <Link to={'/'}>
              主页
            </Link>
          </Nav.Item>
          <Nav.Item>
            <Link to={'/web-ide'}>
              c#在线编辑器
            </Link>
          </Nav.Item>
          <Nav.Item>
            <Link to={'/about'}>
              关于
            </Link>
          </Nav.Item>
          <Nav.Footer>
            <Input onFocus={() => {
              this.setState({
                select: true
              })
            }} onBlur={() => {
              this.setState({
                select: false
              })
            }} value={value} onChange={(value) => {
              this.setState({
                value
              })
            }} onKeyPress={(e) => {
              if (e.altKey === false && e.key === 'Enter') {
                this.onSearch()
              }
            }} className={'search ' + (select ? "search-select" : "")} suffix={<IconSearch onClick={() => this.onSearch()} />} showClear></Input>
          </Nav.Footer>
        </Nav>
      </div>
    )
  }
}
