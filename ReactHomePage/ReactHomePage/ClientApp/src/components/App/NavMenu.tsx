import React, { useState } from "react";
import {
  Collapse,
  Container,
  Navbar,
  NavbarBrand,
  NavbarToggler,
  NavItem,
  NavLink,
} from "reactstrap";
import { Link } from "react-router-dom";
import { LoginMenu } from "../api-authorization/LoginMenu";
import "../../CSS/NavMenu.scss";
import SideBar from "./SideBar";
import { Button } from "reactstrap";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faCoffee } from "@fortawesome/free-solid-svg-icons";

const NavMenu = () => {
    const [collapsed, setCollapsed] = useState(true);
    const [open, setOpen] = useState(false);

    const setOpenProp = () => {
      setOpen(!open);
    }

    return (
      <header>
        <SideBar
          open={open}
          openSideBar={setOpenProp}
        ></SideBar>
        
        <Navbar
          className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3"
          light
        >
          <Container>
            <NavbarBrand tag={Link} to="/">
              ReactHomePage
            </NavbarBrand>
            <NavbarToggler onClick={() => setCollapsed(!collapsed)} className="mr-2" />
            <Collapse
              className="d-sm-inline-flex flex-sm-row-reverse"
              isOpen={!collapsed}
              navbar
            >
              <ul className="navbar-nav flex-grow">
                <NavItem>
                  <NavLink tag={Link} className="text-dark" to="/">
                    Home
                  </NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link} className="text-dark" to="/fetch-data">
                    Fetch data
                  </NavLink>
                </NavItem>
                <LoginMenu></LoginMenu>
                <Button
                  onClick={() => setOpen(!open)}
                >
                  <FontAwesomeIcon icon={faCoffee} />
                </Button>
              </ul>
            </Collapse>
          </Container>
        </Navbar>
      </header>
    );
}

export { NavMenu };
