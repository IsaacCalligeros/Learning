import React, { useEffect } from "react";
import { MovableContainer } from "./MovableContainer";
import container from "./types";
import { useStoreActions, useStoreState } from "../../hooks";
import { times, random } from "lodash";
import { WidthProvider, Responsive, Layout } from "react-grid-layout";
import GridLayout from "react-grid-layout";
import _ from "lodash";
// import "../../CSS/grid-layout.scss";
import Weather from "../Weather/Weather";
import DragFromOutsideLayout from "./grids";
import ContainerTypes from "./types";

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

  const randomId = () => times(20, () => random(35).toString(36)).join("");
  const ResponsiveReactGridLayout = WidthProvider(Responsive);

  useEffect(() => {
    const container1: Layout = {
      i: randomId(),
      w: 3,
      h: 1,
      x: 2,
      y: 0,
    };
    const container2: Layout = {
      i: randomId(),
      w: 2,
      h: 3,
      x: 6,
      y: 1,
    };
    const container3: Layout = {
      i: randomId(),
      w: 2,
      h: 3,
      x: 6,
      y: 2,
    };

    addContainer(container1);
    addContainer(container2);
    addContainer(container3);
  }, []);

  const layouts: ContainerTypes.Layouts = {
      lg: containers
  };

  return <DragFromOutsideLayout layouts={layouts}></DragFromOutsideLayout>;

  //for api to get containers when stored
  // useEffect(() => {
  //   getContainers();
  // }, []);

  // return (
  //   <div className="component-container">

  //   </div>
  // );
};

export { Home };
