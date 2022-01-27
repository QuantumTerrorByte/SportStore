import React from "react";
import {CART, CART_ADD_PRODUCT, CART_REMOVE_PRODUCT, CART_SET_PRODUCT_COUNT, CLEAR_CART, SET_CART} from "../Consts";
import {log} from "../../core/log";
import {store} from "../../index";
import {getCartBackUpAction} from "../actions/CartActionFactory";

const ADD = "add";
const REMOVE = "remove";
const SET = "set";

/*CartModel = [{
    id: 777,
    cartLine: {
        product: { //from simple view
            productId: 777,
            productName: "Name"
            productPrice: 2.2,
            productImg: "https//",
        },
        count: 2
    }
}] todo replace count into product(cart lines is redundant)*/

export function CartReducer(state = initialStateCart(), action) {
    switch (action.type) {
        case SET_CART: //payload {cart:{...cartLines}}
            localStorage.set(CART, action.payload.cart);
            return {...state, ...action.payload.cart};
        case CART_ADD_PRODUCT: //payload {product,count}
            return correctCartLines(state, action, ADD);
        case CART_REMOVE_PRODUCT: //payload {product,count}
            return correctCartLines(state, action, REMOVE);
        case CART_SET_PRODUCT_COUNT: //payload {product,count}
            return correctCartLines(state, action, SET);
        case CLEAR_CART:
            return [];
        default:
            return state;
    }
}

//add remove or set product(s) into storage, then local storage
function correctCartLines(state, action, command) {
    const result = [...state];
    const product = action.payload.product;
    const count = action.payload.count;
    const cartLine = result.filter(e => e.product.productId === product.productId);
    debugger
    if (cartLine.length !== 0) { //check is it new object
        if (cartLine.length >= 1) { //state problems
            throw Error("My ERROR")
        }
        switch (command) { //main branch
            case ADD:
                cartLine[0].count += count;
            case REMOVE:
                cartLine[0].count -= count;
            case SET:
                cartLine[0].count = count;
        }
    } else {   // add if new
        result.push({
            product,
            count,
        });
    }
    const buff = JSON.stringify(result); //todo on promises
    setTimeout(() => {//thread safe
        localStorage.setItem("cart", buff);
    });
    return result;
}

export function initialStateCart() {
    let cart = localStorage.get(CART);
    try {
        if (cart !== null) { //not null can parse (still can be undefined, nan or just string
            cart = JSON.parse(cart);
        }
        if (Array.isArray(cart) && cart.length > 0) { //if not arr, scip second expression
            return cart;
        }
    } catch (error) {
        log(`InitialStateCartException, probably upon attempt get cart from ls and parse, 
        cart value = ${cart}`,error);
    }
    debugger
    if (localStorage.getAuthStatus()) { //todo init order
        store.dispatch(getCartBackUpAction);
    }
    return [];
}

// function initialStateCart2() {
//     const result = [{
//         product: { //from simple view
//             productId: 555,
//             productShortDescription: "Now foods vitamin d3 2000mg with carotine",
//             productPrice: 2.1,
//             productImg: "https://s3.images-iherb.com/mav/mav16261/v/15.jpg",
//         },
//         count: 2
//     }, {
//         product: { //from simple view
//             productId: 777,
//             productShortDescription: "Now foods vitamin d3 2000mg with carotine and free graipfruits",
//             productPrice: 5.1,
//             productImg: "https://s3.images-iherb.com/now/now00990/v/21.jpg",
//         },
//         count: 5
//     }];
//     return result;
// }


