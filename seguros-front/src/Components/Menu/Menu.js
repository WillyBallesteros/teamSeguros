import React, { Component } from "react";
import { NavItem, Navbar, Dropdown, Divider } from "react-materialize";

export default class Menu extends Component {
  render() {
    return (
      <div>
        <Navbar  brand={<a />} alignLinks="right">
          <NavItem href="">Getting started</NavItem>
          <NavItem href="components.html">Components</NavItem>
          <Dropdown trigger={<a />}>
            <a href="#">one</a>
            <a href="#">two</a>
            <Divider />
            <a href="#">three</a>
            <h1>Color</h1>
          </Dropdown>
        </Navbar>
      </div>
    );
  }
}
