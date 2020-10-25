import React from "react";
import Sidebar from "react-sidebar";

const SideBar = ({ open, setOpen }) => {
  return (
    <Sidebar
      sidebar={
        <>
          <b>Sidebar content</b>
          <div>{open}</div>
        </>
      }
      open={open}
      onSetOpen={() => setOpen()}
      styles={{ sidebar: { background: "white" } }}
    >
      <></>
    </Sidebar>
  );
};

export default SideBar;
