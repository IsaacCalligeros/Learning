import { Action, Thunk, Computed } from 'easy-peasy';

import { ComponentLayout } from '../components/containers/types';

export default interface ContainersModel {
  containers: ComponentLayout[];
  currentContainers: Computed<ContainersModel, ComponentLayout[]>;
  setContainers: Action<ContainersModel, ComponentLayout[]>;
  addContainer: Action<ContainersModel, ComponentLayout>;
  updateContainers: Thunk<ContainersModel, ComponentLayout[]>;
  deleteContainer: Thunk<ContainersModel, string>;
  createContainer: Thunk<ContainersModel, ComponentLayout>;
  getContainers: Thunk<ContainersModel>;
  saveContainerState: Thunk<ContainersModel, ComponentLayout>;
}