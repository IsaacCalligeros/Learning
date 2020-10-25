import React, { Component } from "react";
import { render } from "react-dom";
import { Rnd } from "react-rnd";
import PropTypes from "prop-types";
import Weather from "./Weather"

const style = {
  display: "flex",
  alignItems: "center",
  justifyContent: "center",
  border: "solid 1px #ddd",
  background: "#f0f0f0",
};


export class MovableContainer extends Component {
  constructor(props) {
    super(props);
    this.state = {
      x: props.location.x,
      y: props.location.y,
      width: props.location.width,
      height: props.location.height
    };
  }

  render() {
    return (
        <Rnd
          style={style}
          bounds="parent"
          size={{ width: this.state.width, height: this.state.height }}
          position={{ x: this.state.x, y: this.state.y }}
          onDragStop={(e, d) => {
            this.setState({ x: d.x, y: d.y });
          }}
          onResizeStop={(e, direction, ref, delta, position) => {
            this.setState({
              width: ref.style.width,
              height: ref.style.height,
              ...position,
            });
          }}
        >
          <Weather></Weather>
        </Rnd>

    );
  }
}

MovableContainer.propTypes= {
  location: PropTypes.object.isRequired
}
