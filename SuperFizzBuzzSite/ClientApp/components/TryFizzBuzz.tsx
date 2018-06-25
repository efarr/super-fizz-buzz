import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';

interface TryFizzBuzzState {
    fizzBuzz: string[];
    loading: boolean;
    upperBound: string;
}

export class TryFizzBuzz extends React.Component<RouteComponentProps<{}>, TryFizzBuzzState> {
    constructor() {
        super();
        this.state = { fizzBuzz:[], loading: false, upperBound: "" };

    }

    updateUpperBound(value: string) {
        this.setState({ ...this.state, upperBound: value});
    }

    calculate() {
        this.setState({...this.state, loading:true});
        fetch(`api/fizzbuzz/${this.state.upperBound}`)
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
        return <div>
                <ul>
                {this.state.fizzBuzz.map((item) => <li>{item}</li>)}
                </ul>
               </div>;
    }

    renderInputForm() {
        return <div>
            <input type="text" placeholder="Upper Bound" onChange={(e) => { this.updateUpperBound(e.target.value) }} />
            <button onClick={() => { this.calculate() }}>Proceed with Magic</button>
        </div>;
    }
}