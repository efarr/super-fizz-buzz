import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div>
            <h1>Welcome to Super FizzBuzz!</h1>
            <h4>Home of the most flexible FizzBuzz library on the market</h4>
            <p>See source <a href="https://github.com/efarr/super-fizz-buzz/">here</a></p>
        </div>;
    }
}
