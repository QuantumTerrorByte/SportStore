import React from "react";
import {CART_ADD_PRODUCT, CART_REMOVE_PRODUCT, CART_SET_PRODUCT_COUNT, CLEAR_CART} from "../Consts";

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
    const cartLine = result.filter(e => e.product.id === product.id);
    if (cartLine !== undefined) {
        if (cartLine.length !== 1) {
            throw Error
        }
        switch (command) {
            case ADD:
                cartLine[0].count += count;
            case REMOVE:
                cartLine[0].count -= count;
            case SET:
                cartLine[0].count = count;
        }
    } else {
        result.push({
            product,
            count,
        });
    }
    setTimeout(() => {//thread safe
        localStorage.setItem("cart", JSON.stringify(result));
    });
    return result;
}

function initialStateCart() {
    const result = [{
        product: { //from simple view
            productId: 3,
            productShortDescription: "Now foods vitamin d3 2000mg with carotine",
            productPrice: 2.1,
            productImg: "https://s3.images-iherb.com/mav/mav16261/v/15.jpg",
        },
        count: 2
    }, {
        product: { //from simple view
            productId: 3,
            productShortDescription: "Now foods vitamin d3 2000mg with carotine and free graipfruits",
            productPrice: 5.1,
            productImg: "https://s3.images-iherb.com/now/now00990/v/21.jpg",
        },
        count: 5
    }, {
        product: {
            productId: 4,
            productShortDescription: "Now foods vitamin d3 2000mg with glutamat",
            productPrice: 2.0,
            productImg: "https://s3.images-iherb.com/sor/sor04113/v/35.jpg",
        },
        count: 3
    }];
    result.getSummaryPrice = function () {
        let result = 0;
        this.forEach(e => result += e.product.productPrice * e.count);
        return result;
    }
    return result;
}


// if (Auth) {
//     $.ajax({
//         url: `${DOMAIN}/Cart/Add`,
//         type: "POST",
//         dataType: "json",
//         data: {productId: product.id, count},
//     }).fail(jqXHR => console.log(jqXHR));
// }

// const result = [...state];
// let product;
// let count;
// let cartLine;
//
// switch (action.type) {
//     //added product(s) into storage then local storage then on server
//     case CART_ADD_PRODUCT: //payload {product,count}
//         product = action.payload.product;
//         count = action.payload.count;
//         cartLine = result.filter(e => e.product.id === product.id);
//         if (cartLine !== undefined) {
//             if (cartLine.length !== 1) {
//                 throw Error
//             }
//             cartLine[0].count += count;
//         } else {
//             result.push({
//                 product,
//                 count,
//             });
//         }
//
//         setTimeout(() => {//thread safe
//             localStorage.setItem("cart", JSON.stringify(result));
//         });
//         return result;
//     case CART_REMOVE_PRODUCT: //payload {product,count}
//         product = action.payload.product;
//         count = action.payload.count;
//         cartLine = result.filter(e => e.product.id === product.id);
//
//         if (cartLine !== undefined) {
//             if (cartLine.length !== 1) {
//                 throw Error
//             }
//             cartLine[0].count -= count;
//         }
//
//         setTimeout(() => {//thread safe
//             localStorage.setItem("cart", JSON.stringify(result));
//         });
//         return result;
//
//     case CART_SET_PRODUCT_COUNT: //payload {product,count} //todo
//         product = action.payload.product;
//         count = action.payload.count;
//         cartLine = result.filter(e => e.product.id === product.id);
//         if (cartLine !== undefined) {
//             if (cartLine.length !== 1) {
//                 throw Error
//             }
//             cartLine[0].count = count;
//         } else {
//             result.push({
//                 product,
//                 count,
//             });
//         }
//
//         setTimeout(() => {//thread safe
//             localStorage.setItem("cart", JSON.stringify(result));
//         });
//         return result;
//     default:
//         return state;
// }