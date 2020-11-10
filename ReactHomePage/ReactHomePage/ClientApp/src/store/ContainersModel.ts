import { Action, Thunk, Computed } from 'easy-peasy';

import container from '../components/containers/types';
import { Layout } from 'react-grid-layout';

export default interface ContainersModel {
  containers: Layout[];
  currentContainers: Computed<ContainersModel, Layout[]>;
  setContainers: Action<ContainersModel, Layout[]>;
  addContainer: Action<ContainersModel, Layout>;
  updateContainer: Action<ContainersModel, Layout>;
  createContainer: Thunk<ContainersModel, Layout>;
  getContainers: Thunk<ContainersModel>;
}