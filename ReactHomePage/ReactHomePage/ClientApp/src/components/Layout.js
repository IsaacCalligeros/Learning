import React, { Component, useState } from "react";
import { Container } from "reactstrap";
import { NavMenu } from "./NavMenu";
import SideBar from "./SideBar";

export class Layout extends Component {
  static displayName = Layout.name;


  render() {
    return (
      <div>
        <NavMenu />
        {/* <SideBar></SideBar> */}
        <Container>{this.props.children}</Container>
      </div>
    );
  }
}
