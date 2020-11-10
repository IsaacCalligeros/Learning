  
import { action, thunk, computed } from 'easy-peasy';

import ContainersModel from './ContainersModel';
import container from '../components/containers/types';

const Containers: ContainersModel = {
  containers: [],
  currentContainers: computed((state) => state.containers),
  setContainers: action((state, containers) => {
    state.containers = containers;
  }),
  addContainer: action((state, container) => {
    state.containers.push(container);
  }),
  updateContainer: action((state, aContainer) => {
    const elementsIndex = state.containers.findIndex(element => element.i == aContainer.i);
    let newArray = [...state.containers];
    newArray[elementsIndex] = aContainer;
    state.containers = newArray
  }),
  //Tempo code from an example Coding garden tute, to be transfered when serverside set up
  createContainer: thunk(async (state, entry) => {
    const response = await fetch('http://localhost:5454/entries', {
      method: 'POST',
      headers: {
        'content-type': 'application/json',
      },
      body: JSON.stringify(entry),
    });
    const result = await response.json();
    state.addContainer(result);
  }),
  getContainers: thunk(async (state) => {
    const response = await fetch('http://localhost:5454/entries');
    const entries = await response.json();
    state.setContainers(entries);
  }),
};

export default Containers;