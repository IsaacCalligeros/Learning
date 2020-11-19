import React, { useState, useEffect } from "react";
import _ from "lodash";
import { Responsive, WidthProvider, Layout } from "react-grid-layout";
import "../../CSS/grid-layout.scss";
import Weather from "../Weather/Weather";
import ContainerTypes from "./types"
import { useStoreActions, useStoreState } from "../../hooks";
import { v4 as uuidv4 } from 'uuid';

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

  const addContainer = useStoreActions(
    (state) => state.containers.addContainer
  );
  
  const [currentBreakpoint, setCurrentBreakpoint] = useState("lg");
  const [compactType, setCompactType] = useState<string | null>("vertical");
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
    layoutItem.i = uuidv4();
    addContainer(layoutItem);
  };

  const onRemoveItem = (i: any) => {
    //  setLayouts({ lg: _.reject(props.layouts.lg, { i: i }) });
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
