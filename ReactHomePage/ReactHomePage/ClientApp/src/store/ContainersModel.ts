import { Action, Thunk, Computed } from 'easy-peasy';

import { ComponentLayout } from '../components/containers/types';

export default interface ContainersModel {
  containers: ComponentLayout[];
  currentContainers: Computed<ContainersModel, ComponentLayout[]>;
  setContainers: Action<ContainersModel, ComponentLayout[]>;
  addContainer: Action<ContainersModel, ComponentLayout>;
  updateContainer: Action<ContainersModel, ComponentLayout>;
  createContainer: Thunk<ContainersModel, ComponentLayout>;
  getContainers: Thunk<ContainersModel>;
}