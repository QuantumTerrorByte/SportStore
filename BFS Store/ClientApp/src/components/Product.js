import React from "react";
import '../styles/ProductBlockForCostumers.css'
import {useDispatch} from "react-redux";
import {NavLink, useHistory} from "react-router-dom";
import {addToCardAction} from "../redux/actions/CartActionFactory";
import {AUTH_FLAG} from "../redux/Consts";

export function Product(product) {
    const dispatch = useDispatch();
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
                {product.name.toString().length < 75 ? product.name : product.name.substring(0, 75)}
            </div>
            <div className="product-price">
                {Intl.NumberFormat('en-US').format(product.priceUsd)}
            </div>
            <button className="product-add" onClick={(e) => {
                e.stopPropagation();
                e.preventDefault();
                dispatch(addToCardAction(
                    JSON.parse(localStorage.getItem(AUTH_FLAG))?.toLowerCase() === 'true',
                    {
                        productId: product.id,
                        productName: product.name,
                        productPrice: product.priceUsd,
                        productImg: product.imgUrl,
                    }));
            }}>В корзину
            </button>
            <a className="product-comments">//todo
                0 коментариев
            </a>
        </div>
    )
}
