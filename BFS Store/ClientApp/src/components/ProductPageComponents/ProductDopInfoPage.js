import React from "react";
import {NavLink, Route, Switch, useHistory, useLocation, useParams} from "react-router-dom";
import '../../styles/ProductPage.css'
import {useDispatch, useSelector} from "react-redux";


export function ProductInfoPage(productInfoViewModel) {
    const dispatcher = useDispatch();
    const brHistory = useHistory();
    let {productId} = useParams();

    return (
        <div>

        </div>
    );
}