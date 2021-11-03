import React from "react";
import {useLocation} from "react-router-dom";

export function TestComponent(){
    let linkQuery = new URLSearchParams(useLocation().search);
    console.log(linkQuery);
    return <div>
        {linkQuery.toString()}
    </div>
}