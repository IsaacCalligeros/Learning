import React from 'react';
import './App.css';
import WindowHistory from './components/WindowHistory';
import UserInfo from './components/UserInfo';

function App() {
  return (
    <div className="App">
      <WindowHistory></WindowHistory>
          <UserInfo></UserInfo>
    </div>
  );
}

export default App;
