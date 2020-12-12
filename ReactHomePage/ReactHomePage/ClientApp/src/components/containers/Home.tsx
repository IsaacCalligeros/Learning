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
import {  ComponentLayout, ComponentLayouts } from "./types";
import { ComponentType } from "../../models/models";

const Home = () => {
  const containers = useStoreState(
    (state) => state.containers.currentContainers
  );

  const ResponsiveReactGridLayout = WidthProvider(Responsive);

  const getContainers = useStoreActions(
    (state) => state.containers.getContainers
  )

  useEffect(() => {
    getContainers();    
  }, []);

  const layouts: ComponentLayouts = {
      lg: containers
  };
  return <DragFromOutsideLayout layouts={layouts}></DragFromOutsideLayout>;
};

export { Home };
