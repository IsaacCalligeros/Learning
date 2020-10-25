import React, { Component } from "react";
import { MovableContainer } from "./MovableContainer";

export class Home extends Component {
  static displayName = Home.name;

  constructor() {
    super();
    this.state = {
      container1: {
        width: 200,
        height: 200,
        x: 10,
        y: 10,
      },
      container2: {
        width: 200,
        height: 200,
        x: 310,
        y: 10,
      },
    };
  }

  render() {
    return (
      <div className="component-container">
        <MovableContainer location={this.state.container1}></MovableContainer>
        <MovableContainer location={this.state.container2}></MovableContainer>
      </div>
    );
  }
}
