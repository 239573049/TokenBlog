import { Input, Nav } from '@douyinfe/semi-ui'
import { Component } from 'react'
import { IconSemiLogo, IconSearch } from '@douyinfe/semi-icons';
import './index.css'
import { PathEvent } from '../events/pathEvent';

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
            <IconSemiLogo style={{ fontSize: 36 }} />
          </Nav.Header>
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
