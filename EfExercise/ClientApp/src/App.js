import React from 'react'
import { Route, BrowserRouter } from 'react-router-dom';
import Layout from './components/Layout'

import './custom.css'

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

const App = () => {
  const Layout = props => {
    return <Layout select={props.select} />
  }

    return (
      <div>
        <BrowserRouter basename={baseUrl}>
          <Route exact path='/' component={<Layout select="1" />} />
          <Route path='/counter' component={<Layout select="2" />} />
          <Route path='/fetch-data' component={<Layout select="3" />} />
        </BrowserRouter>,
      </div>
    )
}

export default App