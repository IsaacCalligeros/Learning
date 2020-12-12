import { action, thunk, computed } from "easy-peasy";
import axiosInstance from "../axiosInstance";

import ContainersModel from "./ContainersModel";
import { BaseContainer } from "../models/models";

const Containers: ContainersModel = {
  containers: [],
  currentContainers: computed((state) => state.containers),
  setContainers: action((state, containers) => {
    state.containers = containers;
  }),
  addContainer: action((state, container) => {
    state.containers.push(container);
  }),
  deleteContainer: thunk(async (state, i) => {
    const url = `api/Containers/Delete/${i}`;
    axiosInstance
      .delete(url)
      .then((res) => {
        return res.data;
      });
    // const elementsIndex = state.containers.findIndex(
    //   (element) => element.layout.i == aContainer.layout.i
    // );
    // let newArray = [...state.containers];
    // newArray[elementsIndex] = aContainer;
    // state.containers = newArray;
  }),
  updateContainers: thunk(async (state, containers) => {
    axiosInstance
      .post("api/Containers/UpdateContainers", containers)
      .then((res) => {
      });
    // const elementsIndex = state.containers.findIndex(
    //   (element) => element.layout.i == aContainer.layout.i
    // );
    // let newArray = [...state.containers];
    // newArray[elementsIndex] = aContainer;
    // state.containers = newArray;
  }),
  //Tempo code from an example Coding garden tute, to be transfered when serverside set up
  createContainer: thunk(async (state, entry) => {}),
  getContainers: thunk(async (state) => {
    axiosInstance.get("api/Containers/getContainers").then((res) => {
      state.setContainers(res.data);
    });
  }),
  saveContainerState: thunk(async (state, newContainer) => {
    axiosInstance
      .post("api/Containers/SaveContainer", newContainer)
      .then((res) => {});
  }),
};

export default Containers;
