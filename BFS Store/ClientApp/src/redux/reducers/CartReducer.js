import React from "react";
import {
    CART,
    CART_ADD_PRODUCT, CART_DECREMENT_PRODUCT_COUNT,
    CART_REMOVE_PRODUCT,
    CART_SET_PRODUCT_COUNT,
    CLEAR_CART,
    SET_CART
} from "../Consts";
import {log} from "../../core/log";
import {store} from "../../index";
import {getCartBackUpAction} from "../actions/CartActionFactory";

const ADD = "add";
const REMOVE = "remove";
const SET = "set";

// product: { //from simple view
//     productId: 777,
//     productName: "Name",
//     productPrice: 2.2,
//     productImg: "https//",
//     count: 2,
// } todo replace count into product(cart lines is redundant)

export function CartReducer(state = []/*initialStateCart()*/, action) {
    debugger
    switch (action.type) {
        case SET_CART: //payload {cart:{...cartLines}}
            localStorage.setCart(action.payload);
            return [...state, ...action.payload];

        case CART_ADD_PRODUCT: //payload {product,count}
            return correctCartLines(state, action, CART_ADD_PRODUCT);
        case CART_REMOVE_PRODUCT: //payload {product,count}
            return correctCartLines(state, action, CART_REMOVE_PRODUCT);
        case CART_SET_PRODUCT_COUNT: //payload {product,count}
            return correctCartLines(state, action, CART_SET_PRODUCT_COUNT);
        case CART_DECREMENT_PRODUCT_COUNT: //payload {product,count}
            return correctCartLines(state, action, CART_DECREMENT_PRODUCT_COUNT);

        case CLEAR_CART:
            return [];
        default:
            return state;
    }
}

//add remove or set product(s) into storage, then local storage
function correctCartLines(state, action, command) {
    const cart = [...state];
    const product = action.payload;
    const cartProduct = cart.find(e => e.productId === product.productId);
    debugger
    if (cartProduct != null && cartProduct != undefined) { //check is it new object
        switch (command) { //main branch
            case CART_ADD_PRODUCT:
                cartProduct.count += product.count;
                break;
            case CART_DECREMENT_PRODUCT_COUNT: //id
                if (cartProduct.count > 1) {
                    cartProduct.count--;
                }
                break;
            case CART_REMOVE_PRODUCT:
                const productIndex = cart.indexOf(cartProduct);
                cart.splice(productIndex, 1);
                break;
            case CART_SET_PRODUCT_COUNT:
                cartProduct.count = product.count;
                break;
        }
    } else if (command == CART_ADD_PRODUCT || command == CART_SET_PRODUCT_COUNT) {   // add if new
        cart.unshift(product);
    } else if (command == CART_DECREMENT_PRODUCT_COUNT || command == CART_REMOVE_PRODUCT) {
        log("Wrong product id in to cart_decrement_count or cart_remove");
    }
    debugger
    localStorage.setCart(cart); //todo async?
    return cart;
}


function mockInitialStateCart() {
    const result = [{
        productId: 555,
        productShortDescription: "Now foods vitamin d3 2000mg with carotine",
        productPrice: 2.1,
        productImg: "https://s3.images-iherb.com/mav/mav16261/v/15.jpg",
        count: 2
    }, {
        productId: 777,
        productShortDescription: "Now foods vitamin d3 2000mg with carotine and free graipfruits",
        productPrice: 5.1,
        productImg: "https://s3.images-iherb.com/now/now00990/v/21.jpg",
        count: 5
    }];
    return result;
}


