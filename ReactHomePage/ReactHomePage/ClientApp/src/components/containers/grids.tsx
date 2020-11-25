import React, { useState, useEffect } from "react";
import _ from "lodash";
import { Responsive, WidthProvider, Layout } from "react-grid-layout";
import "../../CSS/grid-layout.scss";
import Weather from "../Weather/Weather";
import { useStoreActions, useStoreState } from "../../hooks";
import { v4 as uuidv4 } from "uuid";
import { ComponentLayouts, ControlType, ComponentLayout } from "./types";
import { News } from "../News/News";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faTimes } from "@fortawesome/free-solid-svg-icons";

const ResponsiveReactGridLayout = WidthProvider(Responsive);

interface DragFromOutsideLayoutProps {
  layouts: ComponentLayouts;
}

const DragFromOutsideLayout = (props: DragFromOutsideLayoutProps) => {
  const defaultProps = {
    className: "layout",
    rowHeight: 30,
    onLayoutChange: function () {},
    cols: { lg: 12, md: 10, sm: 6, xs: 4, xxs: 2 },
  };

  const addContainer = useStoreActions(
    (state) => state.containers.addContainer
  );

  const setLayouts = useStoreActions(
    (state) => state.containers.setContainers
  );

  const [currentBreakpoint, setCurrentBreakpoint] = useState("lg");
  const [compactType, setCompactType] = useState<string | null>(null);
  const [mounted, setMounted] = useState(false);
  

  useEffect(() => {
    setMounted(true);
  }, []);

  const onBreakpointChange = () => (breakpoint: any) => {
    setCurrentBreakpoint(currentBreakpoint);
  };

  const onLayoutChange = (layout: any, layouts: any) => {
    console.dir(layout, layouts);
    // this.props.onLayoutChange(layout, layouts);
  };

  const onDrop = (layout: any, layoutItem: Layout, event: any) => {
    console.dir(layout);
    console.dir(layoutItem);
    console.dir(event);
    layoutItem.i = uuidv4();
    const newContainer: ComponentLayout = {
      layout: layoutItem,
      componentType: ControlType.Weather,
    };
    addContainer(newContainer);
  };

  const onRemoveItem = (i: any) => {
    setLayouts(_.reject(props.layouts.lg, l => l.layout.i == i));
  };

  const generateDOM = () => {
    return _.map(props.layouts.lg, (l) => {
      return (
        <div
          key={l.layout.i}
          className="control-container"
          data-grid={l.layout}
        >
          <button className="remove" onClick={() => onRemoveItem(l.layout.i)}>
            <FontAwesomeIcon icon={faTimes} />
          </button>
          {l.componentType == ControlType.Weather && <Weather></Weather>}
          {l.componentType == ControlType.News && <News></News>}
        </div>
      );
    });
  };

  return (
    <div>
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
