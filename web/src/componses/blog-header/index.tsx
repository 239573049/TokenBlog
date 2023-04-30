import { Input, Nav } from '@douyinfe/semi-ui'
import { Component } from 'react'
import { IconSemiLogo, IconSearch } from '@douyinfe/semi-icons';
import './index.css'

export default class BlogHeader extends Component {

  state = {
    select: false
  }

  render() {
    var { select } = this.state;
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
            }} className={'search ' + (select ? "search-select" : "")} suffix={<IconSearch />} showClear></Input>
          </Nav.Footer>
        </Nav>
      </div>
    )
  }
}
