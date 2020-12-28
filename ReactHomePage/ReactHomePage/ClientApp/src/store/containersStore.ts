import _, { create } from "lodash";
import { observable, action, computed, reaction } from "mobx"
import { createContext } from "react"
import axiosInstance from "../axiosInstance"
import { ComponentLayout } from "../components/Containers/types"

export class ContainersStore {
  constructor() {
    this.getContainers();
  }
  
  @observable containers: ComponentLayout[] = [];

  @action setContainers = (containers : ComponentLayout[]) => {
    this.containers = containers;
  }

  @action addContainer =(container: ComponentLayout) => {
    this.containers.push(container);
  }
   
  @action deleteContainer = async (i: number) => {
    const url = `api/Containers/Delete/${i}`;
    axiosInstance
      .delete(url)
      .then((res) => {
        this.setContainers(_.reject(this.containers, (l) => l.layout.i == i.toString()));
      });
  }

  @action updateContainers = async (containers: ComponentLayout[]) => {
    axiosInstance
      .post("api/Containers/UpdateContainers", containers)
      .then((res) => {
        this.containers = containers;
      });
  }

    @action getContainers = () => {
      axiosInstance.get("api/Containers/getContainers").then((res) => {
        this.setContainers(res.data);
      });
    }

    @action saveContainer = (newContainer : ComponentLayout) => {
      axiosInstance
        .post("api/Containers/SaveContainer", newContainer)
        .then((res) => {
          this.addContainer(newContainer);
        });
    };
  };
