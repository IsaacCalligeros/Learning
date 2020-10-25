import React, { Component } from 'react'

export default class UserInfo extends Component {
    languages = window.clientInformation.languages.map((item) =>
    <li key={item}>{item}</li>
);


    render() {
        return (
            <div>
                <p>{window.clientInformation.appVersion}</p>
                <p>{this.languages}</p>
                <p>{window.navigator.platform}</p>
            </div>
        )
    }
}
