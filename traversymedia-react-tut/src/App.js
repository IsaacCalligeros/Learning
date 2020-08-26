import React from "react";
import { BrowserRouter as Router, Route } from "react-router-dom";
import Todos from "./components/Todos";
import Header from "./components/layout/Header";
import About from "./components/pages/about";
import AddTodo from "./components/AddTodo";
import { v4 as uuid } from "uuid";
import axios from 'axios';
import "./App.css";

class App extends React.Component {
  state = {
    todos: [],
  };

  //Toggle complete, gets called from child component and propogated up through parent components to here. App.js seems to be a global store does this get very bulky?
  markComplete = (id) => {
    console.log(id);
    this.setState({
      todos: this.state.todos.map((todo) => {
        if (todo.id === id) {
          todo.completed = !todo.completed;
        }
        return todo;
      }),
    });
  };

  //Delete
  delTodo = (id) => {
    axios.delete('https://jsonplaceholder.typicode.com/todos/${id}').then(res => this.setState({
      todos: [...this.state.todos.filter((todo) => todo.id !== id)],
    }));
    
  };

  //AddTodo
  addTodo = (title) => {
    // const newTodo = {
    //   id: uuid(),
    //   title: title,
    //   completed: false,
    // };
    axios.post('https://jsonplaceholder.typicode.com/todos', {
      title: title,
      completed: false,
    }).then(res => this.setState({ todos: [...this.state.todos, res.data] }));
  };

  getTodos = () => {
    axios.get('https://jsonplaceholder.typicode.com/todos?_limit=10').then(res => this.setState({ todos: res.data }));
  }
  //Lifecycle methods

  componentDidMount() {
    this.getTodos();
  }

  render() {
    return (
      <Router>
        <div className="App">
          <div className="container">
            <Header />
            <Route
              exact
              path="/"
              render={(props) => (
                <React.Fragment>
                  <AddTodo addTodo={this.addTodo} />
                  <Todos
                    todos={this.state.todos}
                    markComplete={this.markComplete}
                    delTodo={this.delTodo}
                  ></Todos>
                </React.Fragment>
              )}
            />
            <Route path="/about" component={About} />
          </div>
        </div>
      </Router>
    );
  }
}

export default App;
