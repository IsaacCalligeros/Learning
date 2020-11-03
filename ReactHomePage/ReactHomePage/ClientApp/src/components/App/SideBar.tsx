import React from "react";
import Sidebar from "react-sidebar";

interface SideBarProps {
  open: boolean;
  openSideBar: () => void
}

const SideBar = ( props: SideBarProps ) => {
  return (
    <Sidebar
      sidebar={
        <>
          <b>Sidebar content</b>
          <div>{props.open}</div>
        </>
      }
      open={props.open}
      onSetOpen={() => props.openSideBar()}
      styles={{ sidebar: { background: "white" } }}
    >
      <></>
    </Sidebar>
  );
};

export default SideBar;
