import { createStore } from 'easy-peasy';

import Store from './types'

import Containers from './Containers';

const store: Store = {
   containers: Containers,
};

export default createStore<Store>(store);