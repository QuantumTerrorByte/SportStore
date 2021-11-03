import React from "react";
import '../styles/LeftPanel.css'
import {Categorise} from "./Categorise";


//view model must be object which props contain {actionCreator, list<items>}
export default function LeftFiltersBar({leftBarViewModel}) {
    let index = 0;
    return Object.keys(leftBarViewModel)
        .map(key => leftBarViewModel[key])
        .map(prop => <Categorise
            itemList={prop.itemList}
            actionCreator={prop.actionCreator}
            tittle={prop.tittle}
            key={index++}
        />);
}