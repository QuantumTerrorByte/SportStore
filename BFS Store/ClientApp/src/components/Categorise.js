import React from "react";
import {useDispatch} from "react-redux";

export function Categorise({itemList, actionCreator, tittle,}) {
    const dispatch = useDispatch();
    let index = 0;
    return (
        <ul className="categorise-block">
            <li className="categorise-tittle">{tittle}</li>
            {
                itemList.map(item =>
                    <li key={index++} className="categorise-item" onClick={() => dispatch(actionCreator(item))}>
                        {item}
                    </li>)
            }
        </ul>
    );
}