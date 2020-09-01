import React, { Component } from 'react';
import { MovableContainer } from "./MovableContainer";

export class Home extends Component {
  static displayName = Home.name;

  constructor() {
    super();
    this.state = {
      width: 200,
      height: 200,
      x: 10,
      y: 10
    };
  }

  render () {
    return (
      <div className="component-container">
        <MovableContainer></MovableContainer>
        <MovableContainer></MovableContainer>
      </div>
    );
  }
}
