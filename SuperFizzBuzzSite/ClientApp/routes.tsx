import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { TryFizzBuzz } from "./components/TryFizzBuzz";

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/try' component={ TryFizzBuzz } />
</Layout>;
