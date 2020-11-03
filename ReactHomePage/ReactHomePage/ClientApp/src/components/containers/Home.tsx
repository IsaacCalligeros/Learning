import React, { Component, useState, useEffect } from "react";
import { MovableContainer } from "./MovableContainer";
import container from "./types";
import { useStoreActions, useStoreState } from "../../hooks";

const Home = () => {
  const addContainer = useStoreActions(
    (state) => state.containers.addContainer
  );
  const containers = useStoreState(
    (state) => state.containers.currentContainers
  );
  const setContainers = useStoreActions(
    (state) => state.containers.setContainers
  );

  useEffect(() => {
    const container1: container = {
      width: 200,
      height: 200,
      x: 10,
      y: 10,
    };
    const container2: container = {
      width: 200,
      height: 200,
      x: 310,
      y: 10,
    };

    addContainer(container1);
    addContainer(container2);
  }, []);

  //for api to get containers when stored
  // useEffect(() => {
  //   getContainers();
  // }, []);

  return (
    <div className="component-container">
      {containers.map((container, idx) => (
        <MovableContainer
          container={container}
          setContainers={setContainers}
          key={idx}
        ></MovableContainer>
      ))}
    </div>
  );
};

export { Home };
