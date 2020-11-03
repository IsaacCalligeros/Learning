import React, { Component } from "react";
import { Rnd } from "react-rnd";
import Weather from "../Weather/Weather"
import container from "./types";

const style = {
  display: "flex",
  alignItems: "center",
  justifyContent: "center",
  border: "solid 1px #ddd",
  background: "#f0f0f0",
};

interface MovableContainerProps {
  setContainers: Function;
  container: container;
}


const MovableContainer = (props: MovableContainerProps) => {
    return (
        <Rnd
          style={style}
          bounds="parent"
          size={{ width: props.container.width, height: props.container.height }}
          position={{ x: props.container.x, y: props.container.y }}
          onDragStop={(e, d) => {
            //TODO: add Context
            // this.setState({ x: d.x, y: d.y });
          }}
          onResizeStop={(e, direction, ref, delta, position) => {
            // this.setState({
            //   width: ref.style.width,
            //   height: ref.style.height,
            //   ...position,
            // });
          }}
        >
          <Weather></Weather>
        </Rnd>

    );
  }

  export { MovableContainer }
