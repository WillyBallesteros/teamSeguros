import React from "react";
import "./App.css";
import { NavItem, Navbar, Dropdown, Divider } from "react-materialize";

function App() {
  return (
    <div>
      <Navbar brand={<a />} alignLinks="right">
        <NavItem href="">Getting started</NavItem>
        <NavItem href="components.html">Components</NavItem>
        <Dropdown trigger={<a />}>
          <a href="#">one</a>
          <a href="#">two</a>
          <Divider />
          <a href="#">three</a>
        </Dropdown>
      </Navbar>
    </div>
  );
}

export default App;
