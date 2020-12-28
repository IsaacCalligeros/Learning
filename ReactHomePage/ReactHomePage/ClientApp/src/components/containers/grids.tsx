import React, { useState, useEffect } from "react";
import _ from "lodash";
import { Responsive, WidthProvider, Layout } from "react-grid-layout";
import "../../CSS/grid-layout.scss";
import Weather from "../Weather/Weather";
import { v4 as uuidv4 } from "uuid";
import { News } from "../News/News";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faTimes } from "@fortawesome/free-solid-svg-icons";
import { ComponentType } from "../../models/models";
import { ContainersStore } from "../../store/containersStore";
import { observer } from "mobx-react-lite";
import { ComponentLayout, ComponentLayouts } from "./types";
import { Portfolio } from "../Portfolio/Portfolio";

const ResponsiveReactGridLayout = WidthProvider(Responsive);

interface DragFromOutsideLayoutProps {
  containersStore: ContainersStore;
}

const DragFromOutsideLayout = observer((props: DragFromOutsideLayoutProps) => {
  const layouts: ComponentLayouts = {
    lg: props.containersStore.containers,
  };

  const defaultProps = {
    className: "layout",
    rowHeight: 30,
    onLayoutChange: function () {},
    cols: { lg: 12, md: 10, sm: 6, xs: 4, xxs: 2 },
  };

  const [currentBreakpoint, setCurrentBreakpoint] = useState("lg");
  const [compactType, setCompactType] = useState<string | null>(null);
  const [mounted, setMounted] = useState(false);
  const [isInitialLoad, setInitialLoad] = useState(true);

  useEffect(() => {
    setMounted(true);
  }, []);

  const onBreakpointChange = () => (breakpoint: any) => {
    setCurrentBreakpoint(currentBreakpoint);
  };

  const onLayoutChange = (layouts: Layout[]) => {
    // should be a clener way
    // if (layouts.length > 0 && !isInitialLoad) {
    //   const layoutIds = layouts.map((l) => l.i);
    //   const localLayouts = _.clone(props.layouts);
    //   layouts.forEach((layout) => {
    //     const idx = layoutIds.indexOf(layout.i);
    //     if (idx !== -1) {
    //       localLayouts.lg[idx].layout = layout;
    //     }
    //   });
    //   updateLayout(localLayouts.lg);
    // }
    // setInitialLoad(false);
  };

  const onDrop = (layout: any, layoutItem: Layout, event: any) => {
    layoutItem.i = uuidv4();
    const newContainer: ComponentLayout = {
      layout: layoutItem,
      componentType: ComponentType.Weather,
    };
    props.containersStore.addContainer(newContainer);

    props.containersStore.saveContainer(newContainer);
  };

  const onRemoveItem = (i: any) => {
    props.containersStore.deleteContainer(i);
  };

  const generateDOM = () => {
    return _.map(layouts.lg, (l) => {
      return (
        <div
          key={l.layout.i}
          className="control-container"
          data-grid={l.layout}
        >
          <button className="remove" onClick={() => onRemoveItem(l.layout.i)}>
            <FontAwesomeIcon icon={faTimes} />
          </button>
          {l.componentType == ComponentType.Weather && <Weather></Weather>}
          {l.componentType == ComponentType.News && <News></News>}
          {l.componentType == ComponentType.Portfolio && <Portfolio></Portfolio>}
        </div>
      );
    });
  };

  return (
    <div>
      <ResponsiveReactGridLayout
        {...defaultProps}
        onBreakpointChange={() => onBreakpointChange}
        onLayoutChange={onLayoutChange}
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
});

export default DragFromOutsideLayout;
