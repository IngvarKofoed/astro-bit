import * as React from 'react';
import { Route, Switch } from 'react-router-dom';
import './App.css';
import { Menu, Container } from 'semantic-ui-react';
import { Home } from './Home';
import { ScrollToTop } from './ScrollToTop';
import { Gate } from './gate/Gate';

// import logo from './logo.svg';



class App extends React.Component {
  /* componentDidUpdate(prevProps: any, prevState: any, snapshot: any) {
//    if (this.props.location !== prevProps.location) {
      window.scrollTo(0, 0)
  //  }
  } */

  public render() {
    return (
        <div>
          <ScrollToTop />          
          <Menu fixed='top' inverted>
            <Container>
              <Menu.Item as='a' header>
                AstroBit
              </Menu.Item>
              <Menu.Item as='a'>Home</Menu.Item>

            {/*   <Dropdown item simple text='Dropdown'>
                <Dropdown.Menu>
                  <Dropdown.Item>List Item</Dropdown.Item>
                  <Dropdown.Item>List Item</Dropdown.Item>
                  <Dropdown.Divider />
                  <Dropdown.Header>Header Item</Dropdown.Header>
                  <Dropdown.Item>
                    <i className='dropdown icon' />
                    <span className='text'>Submenu</span>
                    <Dropdown.Menu>
                      <Dropdown.Item>List Item</Dropdown.Item>
                      <Dropdown.Item>List Item</Dropdown.Item>
                    </Dropdown.Menu>
                  </Dropdown.Item>
                  <Dropdown.Item>List Item</Dropdown.Item>
                </Dropdown.Menu>
              </Dropdown> */}

            </Container>
          </Menu>
          
          <Container text style={{ marginTop: '7em' }}>
            <Switch>
              <Route exact path='/' component={Home} />
              <Route exact path='/:id' component={Home} />
              <Route exact path='/gate/:gateNumber' component={Gate} />
            </Switch> 

 {/*            <Dropdown placeholder='Select Person' fluid search selection options={personOptions} onChange={this.personSelected.bind(this)} />
            <HumanDesignPlanets humanDesign={this.state.selectedHumanDesign} />
  */}         </Container>
        </div>
    );
  }

 
}

export default App;
