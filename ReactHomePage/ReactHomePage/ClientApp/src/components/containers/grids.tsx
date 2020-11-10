import React, { useState, useEffect } from "react";
import _ from "lodash";
import { Responsive, WidthProvider } from "react-grid-layout";
import "../../CSS/grid-layout.scss";
import Weather from "../Weather/Weather";
import ContainerTypes from "./types"

const ResponsiveReactGridLayout = WidthProvider(Responsive);

interface DragFromOutsideLayoutProps {
  layouts:  ContainerTypes.Layouts;
}

const DragFromOutsideLayout = (props: DragFromOutsideLayoutProps) => {
  const defaultProps = {
    className: "layout",
    rowHeight: 30,
    onLayoutChange: function () {},
    cols: { lg: 12, md: 10, sm: 6, xs: 4, xxs: 2 },
  };
  const [currentBreakpoint, setCurrentBreakpoint] = useState("lg");
  const [compactType, setCompactType] = useState<string | null>("vertical");
  const [mounted, setMounted] = useState(false);

  useEffect(() => {
    setMounted(true);
  }, []);

  const onBreakpointChange = () => (breakpoint: any) => {
    setCurrentBreakpoint(currentBreakpoint);
  };

  const onCompactTypeChange = () => {
    const oldCompactType = compactType;
    const newCompactType =
      oldCompactType === "horizontal"
        ? "vertical"
        : oldCompactType === "vertical"
        ? null
        : "horizontal";
    setCompactType(newCompactType);
  };

  const onLayoutChange = (layout: any, layouts: any) => {
    console.dir(layout, layouts);
    // this.props.onLayoutChange(layout, layouts);
  };

  const onDrop = (layout: any, layoutItem: any, event: any) => {
    alert(
      `Dropped element props:\n${JSON.stringify(
        layoutItem,
        ["x", "y", "w", "h"],
        2
      )}`
    );
  };

  const onRemoveItem = (i: any) => {
    // setLayouts({ lg: _.reject(props.layouts.lg, { i: i }) });
  };

  const generateDOM = () => {
    return _.map(props.layouts.lg, (l) => {
      return (
        <div key={l.i} className="control-container" data-grid={l}>
          <span className="remove" onClick={() => onRemoveItem(l.i)}>
            X {l.i}
          </span>
          <Weather></Weather>
        </div>
      );
    });
  };

  return (
    <div>
      <div>
        Current Breakpoint: {currentBreakpoint} (
        {/* {this.props.cols[this.state.currentBreakpoint]} columns) */}
      </div>
      <div>Compaction type: {compactType || "No Compaction"}</div>
      <button onClick={onCompactTypeChange}>Change Compaction Type</button>
      <div
        className="droppable-element"
        draggable={true}
        unselectable="on"
        // this is a hack for firefox
        // Firefox requires some kind of initialization
        // which we can do by adding this attribute
        // @see https://bugzilla.mozilla.org/show_bug.cgi?id=568313
        onDragStart={(e) => e.dataTransfer.setData("text/plain", "")}
      >
        Droppable Element (Drag me!)
      </div>
      <ResponsiveReactGridLayout
        {...defaultProps}
        onBreakpointChange={() => onBreakpointChange}
        //   onLayoutChange={this.onLayoutChange}
        onDrop={onDrop}
        // WidthProvider option
        measureBeforeMount={false}
        // I like to have it animate on mount. If you don't, delete `useCSSTransforms` (it's default `true`)
        // and set `measureBeforeMount={true}`.
        useCSSTransforms={mounted}
        compactType={compactType as any}
        preventCollision={!compactType}
        isDroppable={true}
      >
        {generateDOM()}
      </ResponsiveReactGridLayout>
    </div>
  );
};

export default DragFromOutsideLayout;
