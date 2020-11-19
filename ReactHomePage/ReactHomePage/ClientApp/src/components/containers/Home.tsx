import React, { useEffect } from "react";
import { useStoreActions, useStoreState } from "../../hooks";
import { times, random } from "lodash";
import { WidthProvider, Responsive, Layout } from "react-grid-layout";
import GridLayout from "react-grid-layout";
import _ from "lodash";
// import "../../CSS/grid-layout.scss";
import Weather from "../Weather/Weather";
import DragFromOutsideLayout from "./grids";
import { v4 as uuidv4 } from 'uuid';
import { ControlType, ComponentLayout, ComponentLayouts } from "./types";

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

  const ResponsiveReactGridLayout = WidthProvider(Responsive);

  useEffect(() => {
    const container1: ComponentLayout = {
      layout: {
      i: uuidv4(),
      w: 2,
      h: 3,
      x: 6,
      y: 1,
      },
      componentType: ControlType.Weather
    };
    const container2: ComponentLayout = {
      layout: {
      i: uuidv4(),
      w: 2,
      h: 3,
      x: 6,
      y: 1,
      },
      componentType: ControlType.Weather
    };
    const container3: ComponentLayout = {
      layout: {
      i: uuidv4(),
      w: 2,
      h: 3,
      x: 6,
      y: 1,
      },
      componentType: ControlType.Weather
    };

    addContainer(container1);
    addContainer(container2);
    addContainer(container3);
  }, []);

  const layouts: ComponentLayouts = {
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
