This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## Available Scripts

In the project directory, you can run:

### `npm start`

Following tutorial https://www.youtube.com/watch?v=sBws8MSXN7A to learn basic starting point of react.

Components very similar to Vue, seems like instead of having v-for or html/js hybrid elements you tend to just write the js in the markup instead.

Props get passed through within component tags and PropTypes are good convention, somewhat typing interactions between components i guess seems weird in the case of Array/Object but anyway. 
Camel Case on component names/inline styles although not sure if inline styles are smiled upon at this stage just used in video though.
Styling seems real weird, no css and you can set it as props from consts. The function based styling is cool though


### Props

passed down to component via <Todo propName={ propValue }></Todo>
as far as i know at the moment there is'nt a globally accessible store i.e. vuex with mutations and actions. So if a child prop has some change to propogate up we want to have a prop in the parent component and call something like 

this.props.markComplete

and the parent component has some method like 

    markComplete = (e) => {
        console.log('this.props');
      }


