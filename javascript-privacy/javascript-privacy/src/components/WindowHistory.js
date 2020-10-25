import React, { Component } from 'react'

export default class WindowHistory extends Component {
    
    componentDidMount() {
        console.log(window.history);
        console.log(window.sessionStorage);
        console.log(document.cookie);
        console.log(window);

    }

    render() {
        return (
            <div>
                
            </div>
        )
    }
}
