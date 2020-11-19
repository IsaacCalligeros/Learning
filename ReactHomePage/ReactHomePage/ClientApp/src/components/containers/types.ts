import { Layout } from "react-grid-layout";

export enum ControlType {
  Weather,
  News,
}
export interface ComponentLayout {
  layout: Layout;
  componentType: ControlType;
}
export interface ComponentLayouts {
  lg: ComponentLayout[];
}
