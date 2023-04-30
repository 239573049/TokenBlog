import { Input, Nav } from '@douyinfe/semi-ui'
import { Component } from 'react'
import { IconSemiLogo, IconSearch } from '@douyinfe/semi-icons';


export default class BlogHeader extends Component {

  state = {
    width: '150px'
  }

  render() {
    var { width } = this.state;
    return (
      <div>
        <Nav mode="horizontal" defaultSelectedKeys={['Home']}>
          <Nav.Header>
            <IconSemiLogo style={{ fontSize: 36 }} />
          </Nav.Header>
          <Nav.Footer>
            <Input onFocus={() => {
              this.setState({
                width: '180px'
              })
            }} onBlur={() => {
              this.setState({
                width: '150px'
              })
            }} style={{ width: width }} suffix={<IconSearch />} showClear></Input>
          </Nav.Footer>
        </Nav>
      </div>
    )
  }
}
