import React from "react";
import {useLocation, useParams} from "react-router-dom";

export function TestProductId() {
    let {Id} = useParams();
    return <div>
        {Id}
    </div>
}