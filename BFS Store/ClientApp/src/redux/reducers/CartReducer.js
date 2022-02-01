import React from "react";
import {
    CART,
    CART_ADD_PRODUCT,
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

export function CartReducer(state = []/*initialStateCart()*/, action) {
    debugger
    switch (action.type) {
        case SET_CART: //payload {cart:{...cartLines}}
            localStorage.setCart(action.payload);
            return [...state, ...action.payload];
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
    const cart = [...state];
    const product = action.payload.product;
    const count = action.payload.count;
    const cartLine = cart.filter(e => e.product.productId === product.productId);
    debugger
    if (cartLine.length !== 0) { //check is it new object
        if (cartLine.length > 1) { //state problems
            throw Error("My ERROR")
        }
        switch (command) { //main branch
            case ADD:
                cartLine[0].count += count;
                break;
            case REMOVE:
                cartLine[0].count -= count;
                break;
            case SET:
                cartLine[0].count = count;
                break;
        }
    } else {   // add if new
        cart.push({
            product,
            count,
        });
    }
    debugger
    localStorage.setCart(cart); //todo async?
    return cart;
}


function mockInitialStateCart() {
    const result = [{
        product: { //from simple view
            productId: 555,
            productShortDescription: "Now foods vitamin d3 2000mg with carotine",
            productPrice: 2.1,
            productImg: "https://s3.images-iherb.com/mav/mav16261/v/15.jpg",
        },
        count: 2
    }, {
        product: { //from simple view
            productId: 777,
            productShortDescription: "Now foods vitamin d3 2000mg with carotine and free graipfruits",
            productPrice: 5.1,
            productImg: "https://s3.images-iherb.com/now/now00990/v/21.jpg",
        },
        count: 5
    }];
    return result;
}


