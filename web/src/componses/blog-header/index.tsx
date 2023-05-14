import { Avatar, Button, Input, Nav } from '@douyinfe/semi-ui'
import { Component } from 'react'
import { IconSearch, IconMoon, IconSun } from '@douyinfe/semi-icons';
import './index.css'
import { PathEvent } from '../events/pathEvent';
import { Link } from 'react-router-dom';

const body = document.body;

export default class BlogHeader extends Component {

  state = {
    select: false,
    value: '',
    dark: body.hasAttribute('theme-mode')
  }

  onSearch() {
    var { value } = this.state;
    PathEvent.emit('blog-path', {
      value: value,
    })
  }

  onDark() {
    var { dark } = this.state;
    dark = !dark;
    if (body.hasAttribute('theme-mode')) {
      body.removeAttribute('theme-mode');
    } else {
      body.setAttribute('theme-mode', 'dark');
    }

    this.setState({ dark })

  }

  render() {
    var { select, value, dark } = this.state;
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
            <Button style={{ marginLeft: '5px' }} icon={dark ? <IconSun onClick={() => this.onDark()} /> : <IconMoon onClick={() => this.onDark()} />}>
            </Button>
          </Nav.Footer>
        </Nav>
      </div>
    )
  }
}
