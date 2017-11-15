/* eslint-disable import/no-named-as-default */
import React from 'react';
import PropTypes from 'prop-types';
import { Switch, Route, Redirect } from 'react-router-dom';
import TabHeader from './TabHeader';
import NotFoundPage from './NotFoundPage';
import IncidentPage from '../containers/IncidentPage';
import NotificationPage from '../containers/NotificationPage';

// This is a class-based component because the current
// version of hot reloading won't hot reload a stateless
// component at the top-level.

class App extends React.Component {
  render() {
    const TopTabs = ['Incidents', 'Notifications'];
    return (
      <div>
        <TabHeader Headers={TopTabs} />
        <Switch>
          <Route exact path="/" render={()=>(<Redirect to= "/Incidents" />)} />
          <Route exact path="/Incidents" render={()=>(<Redirect to= "/Incidents/Current" />)} />
          <Route exact path="/Notifications" render={()=>(<Redirect to= "/Notifications/Current" />)} />
          <Route path="/Incidents/:View" component={IncidentPage} />
          <Route path="/Notifications/:View" component={NotificationPage} />
          <Route component={NotFoundPage} />
        </Switch>
      </div>
    );
  }
}

App.propTypes = {
  children: PropTypes.element
};

export default App;
