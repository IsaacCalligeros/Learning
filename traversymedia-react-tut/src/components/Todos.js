import React from "react";
import TodoItem from "./TodoItem";
//Prop types
import PropTypes from 'prop-types';

class Todos extends React.Component {

  render() {
    return this.props.todos.map((todo) => (
    <TodoItem key={ todo.id } todo={ todo } markComplete={this.props.markComplete} delTodo={this.props.delTodo}></TodoItem>
    ))
  }
}

//Setting up the prop types, apparently good practice, assuming this would be defining the types that can be passed to the object
//Might need to look up for clarification after.
Todos.propTypes = {
    todos: PropTypes.array.isRequired,
    markComplete: PropTypes.func.isRequired,
    delTodo: PropTypes.func.isRequired
}

export default Todos;
