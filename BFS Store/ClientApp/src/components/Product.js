import React from "react";
import '../styles/ProductBlockForCostumers.css'
import {useDispatch} from "react-redux";
import {getAndRouteProductPage} from "../redux/ProductsActionsFactory";
import {NavLink, useHistory} from "react-router-dom";

export function Product(product) {
    const dispatch = useDispatch();
    const brHistory = useHistory();
    return (
        <div className="product-block">
            <div className="product-banner-holder">
                <div className="product-banner">топ продаж</div>
            </div>
            <NavLink to={`/Info/${product.id}`}
               className="product-img">
                <img src={product.imgUrl} alt="Pic" className="product-img"/>
            </NavLink>
            <div className="product-name">
                {product.name.toString().length < 75 ? product.name : product.name.substring(0, 75)}
            </div>
            <div className="product-price">
                {Intl.NumberFormat('en-US').format(product.priceUsd)}
            </div>
            <button className="product-add" onClick={(e) =>
                console.log(product.id + " addToCartClick")}>В корзину
            </button>
            <a className="product-comments">
                0 коментариев
            </a>
        </div>
    )
}
