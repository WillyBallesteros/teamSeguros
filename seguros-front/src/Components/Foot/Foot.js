import React, { Component } from "react";
import { Footer } from "react-materialize";

export default class Foot extends Component {
  render() {
    return (
      <div>
        <Footer
          copyrights="&copy 2015 Copyright Text"
          moreLinks={<a />}
          links={<ul />}
          className="example"
        >
          <h5 className="white-text">Footer Content</h5>
          <p className="grey-text text-lighten-4">
            You can use rows and columns here to organize your footer content.
          </p>
        </Footer>
      </div>
    );
  }
}
