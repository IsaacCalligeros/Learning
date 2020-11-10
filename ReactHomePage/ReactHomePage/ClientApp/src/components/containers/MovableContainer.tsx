import React, { Component } from "react";
import { Rnd } from "react-rnd";
import Weather from "../Weather/Weather"
import container from "./types";
import "../../CSS/container-module.css";

const style = {
  display: "flex",
  alignItems: "center",
  justifyContent: "center",
  border: "solid 1px #ddd",
  background: "#f0f0f0",
  overflow: "hidden"
};

// interface MovableContainerProps {
//   updateContainer: Function;
//   container: container;
// }

// const MovableContainer = (props: MovableContainerProps) => {
  const MovableContainer = () => {
    return (
        // <Rnd
        //   style={style}
        //   bounds="parent"
        //   size={{ width: props.container.width, height: props.container.height }}
        //   position={{ x: props.container.x, y: props.container.y }}
        //   onDragStop={(e, d) => {
        //     //TODO: should be cleaner.
        //     const updatedContainer = props.container;
        //     updatedContainer.x = d.x;
        //     updatedContainer.y = d.y;
        //     props.updateContainer(updatedContainer);
        //   }}
        //   onResizeStop={(e, direction, ref, delta, position) => {
        //     const updatedContainer = props.container;
        //     updatedContainer.width = parseInt(ref.style.width);
        //     updatedContainer.height = parseInt(ref.style.height);
        //     props.updateContainer(updatedContainer);
        //   }}
        // >
        //   <div>
        //   <Weather></Weather>
        //   </div>
        // </Rnd>
      <></>
    );
  }

  export { MovableContainer }
