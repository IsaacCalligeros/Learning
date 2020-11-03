import React, { Component, useState, useEffect } from "react";
import { MovableContainer } from "./MovableContainer";
import container from "./types";
import { useStoreActions, useStoreState } from "../../hooks";
import { times, random } from "lodash";

const Home = () => {
  const addContainer = useStoreActions(
    (state) => state.containers.addContainer
  );
  const containers = useStoreState(
    (state) => state.containers.currentContainers
  );
  const updateContainer = useStoreActions(
    (state) => state.containers.updateContainer
  );

  const randomId = () => times(20, () => random(35).toString(36)).join('');

  useEffect(() => {
    const container1: container = {
      id: randomId(),
      width: 200,
      height: 200,
      x: 10,
      y: 10,
    };
    const container2: container = {
      id: randomId(),
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
      {containers?.map((container, idx) => (
        <MovableContainer
          container={container}
          updateContainer={updateContainer}
          key={idx}
        ></MovableContainer>
      ))}
    </div>
  );
};

export { Home };
