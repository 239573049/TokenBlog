import { Avatar, Button, Input, Nav } from '@douyinfe/semi-ui'
import React, { Component } from 'react'
import { IconSemiLogo, IconBell, IconSearch, IconBytedanceLogo, IconHome, IconLive, IconSetting } from '@douyinfe/semi-icons';


export default class BlogHeader extends Component {
  render() {
    return (
      <div>
         <Nav mode="horizontal" defaultSelectedKeys={['Home']}>
                        <Nav.Header>
                            <IconSemiLogo style={{ fontSize: 36 }} />
                        </Nav.Header>
                        <Nav.Footer>
                            <Input suffix={<IconSearch />} showClear></Input>
                        </Nav.Footer>
                    </Nav>
      </div>
    )
  }
}
