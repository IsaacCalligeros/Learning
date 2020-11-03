import { Action, Thunk, Computed } from 'easy-peasy';

import container from '../components/containers/types';

export default interface ContainersModel {
  containers: container[];
  currentContainers: Computed<ContainersModel, container[]>;
  setContainers: Action<ContainersModel, container[]>;
  addContainer: Action<ContainersModel, container>;
  createContainer: Thunk<ContainersModel, container>;
  getContainers: Thunk<ContainersModel>;
}