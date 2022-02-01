import React from "react";

import {Categorise} from "./Categorise";

//view model must be object which props contain {actionCreator, list<items>}
export default function LeftFiltersBar({leftBarViewModel}) {//todo refactor
    let index = 0;
    return <div className="leftBar">
        {Object.keys(leftBarViewModel)
            .map(key => leftBarViewModel[key])
            .map(prop => <Categorise
                itemList={prop.itemList}
                actionCreator={prop.actionCreator}
                tittle={prop.tittle}
                key={prop.tittle}
            />)}</div>
}