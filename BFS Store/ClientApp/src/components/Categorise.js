import React from "react";
import {useDispatch} from "react-redux";

export function Categorise({itemList, actionCreator, tittle,}) {
    const dispatch = useDispatch();
    let index = 0;
    return (
        <div className="categorise-block">
            <div className="categorise-tittle">{tittle}</div>
            {
                itemList.map(item =>
                    <div key={index++} className="categorise-item" onClick={() => dispatch(actionCreator(item))}>
                        {item}
                    </div>)
            }
        </div>
    );
}