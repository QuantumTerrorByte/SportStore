import React from "react";
import '../styles/ProductBlockForCostumers.css'
import {useDispatch} from "react-redux";
import {NavLink, useHistory} from "react-router-dom";
import {addToCardAction} from "../redux/actions/CartActionFactory";
import {AUTH_FLAG} from "../redux/Consts";

export function Product(product) { //todo local state flag
    const dispatch = useDispatch();
    const prodFormatName = product.name.toString().length < 50 ? product.name : product.name.substring(0, 50);
    const brHistory = useHistory();
    return (
        <div className="product-block">
            <div className="product-banner-holder">
                <div className="product-banner">топ продаж</div>
            </div>
            <NavLink to={{
                pathname: `/ProductInfoPage/`, state: {productId: product.id}
            }} className="product-img">
                <img src={product.imgUrl} alt="Pic" className="product-img"/>
            </NavLink>
            <div className="product-name">
                {prodFormatName}
            </div>
            <h3>
                {new Intl.NumberFormat('de-DE', {
                    style: 'currency',
                    currency: 'USD'
                }).format(product.priceUsd)}
            </h3>
            <button className="product-add" onClick={(e) => {
                e.stopPropagation();
                e.preventDefault();
                dispatch(addToCardAction({
                    productId: product.id,
                    productName: prodFormatName,
                    productPrice: product.priceUsd,
                    productImg: product.imgUrl,
                    count: 1,
                }));
            }}>В корзину
            </button>
            <a className="product-comments"
               onClick={e => {
                   e.stopPropagation();
                   e.preventDefault();
               }}>
                0 коментариев
            </a>
        </div>
    )
}
