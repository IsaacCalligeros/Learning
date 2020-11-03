import React from 'react';
import { Route } from 'react-router';
import { Layout } from './components/App/Layout';
import { Home } from './components/containers/Home';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';

import Container from '@material-ui/core/Container';

import './custom.css'
import { Link, Switch, Redirect } from 'react-router-dom';
import { NavMenu } from './components/App/NavMenu';

const App: React.FC = () => {
  return (
    <div>
      <NavMenu></NavMenu>
      <Container maxWidth="md">
        <Switch>
          <AuthorizeRoute exact path="/" component={Home} />
          <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
          <Route exact path="/about">
            <h1>About Page</h1>
          </Route>
          <Redirect to="/" />
        </Switch>
      </Container>
    </div>
  );
};

export default App;
