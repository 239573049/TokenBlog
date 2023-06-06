import { Button, Form, Notification } from '@douyinfe/semi-ui';
import React, { Component } from 'react';
import UserInfoService from '../../services/userInfoService';
import './index.css';

export default class Login extends Component {
  handleSubmit(values: any) {
    UserInfoService.Login(values.account, values.password)
      .then((res) => {
        if (res) {
          Notification.success({
            title: '登录成功',
            content: '欢迎回来',
          });
          localStorage.setItem('token', res as string);
          window.location.href = '/manage';
        }
      })
      .catch((error) => {
        Notification.error({
          title: '登录失败',
          content: error.response.data.message,
        });
      });
  }

  render() {
    return (
      <div className="container">
        <div className="login-card">
          <h1 style={{ textAlign: 'center', marginBottom: '30px' }}>博客后台登录</h1>
          <Form onSubmit={(values) => this.handleSubmit(values)}>
            {({ formState, values, formApi }) => (
              <>
                <Form.Input
                  field='account'
                  label='账号'
                  style={{ width: '100%', marginBottom: '20px' }}
                  placeholder='请输入您的账号'
                />
                <Form.Input
                  field='password'
                  label='密码'
                  style={{ width: '100%', marginBottom: '20px' }}
                  placeholder='请输入您的密码'
                />
                <div className="button-container">
                  <Button block htmlType='submit' type='tertiary'>登录</Button>
                </div>
              </>
            )}
          </Form>
        </div>
      </div>
    );
  }
}
