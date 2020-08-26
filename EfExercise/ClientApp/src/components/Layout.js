import React from 'react'
import Home from './Home'

const Layout = props => {

  const Select = props =>{
    switch(props.select)
    {
      case 1:
        return <Home />
      break
      case 2:
        return <Home />
      break
      case 3:
        return <Home />
      break
      case 4:
        return <Home />
      break
    }
  }

  return(
    <div>
      <div>

      </div>
      <div className="container">
        <h1 className="title">Moqueca</h1>
        <div>
          <Select select={props.select} />
        </div>
      </div>
    </div>
  )
}

export default Layout