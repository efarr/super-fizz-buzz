import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';

interface TryFizzBuzzState {
    fizzBuzz: string[];
    loading: boolean;
    upperBound: string;
    overrides: string;
}

export class TryFizzBuzz extends React.Component<RouteComponentProps<{}>, TryFizzBuzzState> {
    constructor() {
        super();
        this.state = { fizzBuzz:[], loading: false, upperBound: "100", overrides: "3,Fizz,5,Buzz" };

    }

    updateUpperBound(value: string) {
        this.setState({ ...this.state, upperBound: value});
    }

    updateOverrides(value: string) {
        this.setState({ ...this.state, overrides: value });
    }

    calculate() {
        this.setState({...this.state, loading:true});
        fetch('api/fizzbuzz/', {
            method: 'post',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ "upperBound": this.state.upperBound, "overrides": this.state.overrides })
        })
            .then(response => response.json())
            .then(data => {
                this.setState({...this.state, fizzBuzz: data, loading: false });
            });
    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderInputForm();

        let fizzBuzz = this.state.fizzBuzz.length > 0
            ? this.renderResults()
            : <p></p>;

        return <div>
            <h1>Try Super FizzBuzz</h1>
            {contents}
            {fizzBuzz}
        </div>;
    }

    renderResults() {
        return <div><ul>
                {this.state.fizzBuzz.map((item) => <li>{item}</li>)}
               </ul></div>;
    }

    renderInputForm() {
        return <div>
            <label>Upper Bound:</label>
            <input type="text" placeholder="enter a number up to 1000" value={this.state.upperBound} onChange={(e) => { this.updateUpperBound(e.target.value) }} /><br/>
            <label>Override Multiples:</label>
            <input type="text" placeholder="multiple,string,multiple,string (eg. 3,Fizz,5,Buzz)" value={this.state.overrides} onChange={(e) => { this.updateOverrides(e.target.value) }} /><br />
            <button onClick={() => { this.calculate() }}>Proceed with Magic</button>
        </div>;
    }
}