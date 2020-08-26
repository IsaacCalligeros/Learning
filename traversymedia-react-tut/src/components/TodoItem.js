import React, { Component } from "react";
import PropTypes from "prop-types";

export class TodoItem extends Component {
  getStyle = () => {
    return {
      backgroundColor: "#f4f4f4",
      textDecoration: this.props.todo.completed ? "line-through" : "none",
      padding: "10px",
      borderBottom: "1px #ccc dotted",
    };
  };

  //arrow operator automatically binds context for this, i.e. if using method style this.props undefined

  render() {

    //Destructuring
    const { id, title } = this.props.todo;

    return (
      <div style={this.getStyle()}>
        <p>
            <input type="checkbox" onChange={ this.props.markComplete.bind(this, id) }></input>
            { title }
            <button style={btnStyle} onClick={this.props.delTodo.bind(this, id)}>X</button>
            </p>

      </div>
    );
  }
}

TodoItem.propTypes = {
  todo: PropTypes.object.isRequired,
  markComplete: PropTypes.func.isRequired,
  delTodo: PropTypes.func.isRequired
};

const btnStyle ={
    background: '#ff0000',
    color: '#fff',
    border: 'none',
    padding: '5px 10px',
    borderRadius: '50%',
    cursor: 'pointer',
    float: 'right'
}

export default TodoItem;
