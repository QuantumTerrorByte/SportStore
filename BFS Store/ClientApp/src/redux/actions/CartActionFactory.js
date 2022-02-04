import {requestDecorator} from "../../requests/Requests";
import {
    AUTH_DOMAIN,
    CART,
    CART_ADD_PRODUCT, CART_DECREMENT_PRODUCT_COUNT,
    CART_REMOVE_PRODUCT,
    CART_SET_PRODUCT_COUNT,
    DOMAIN,
    SET_CART,
    SWITCH_MINI_CART_FLAG, USER_LOGIN
} from "../Consts";
import {log} from "../../core/log";
import {store} from "../../index";
import {getAuthFlag} from "../../core/getAuthFlag";
import $ from "jquery";
import {AUTH_CONTROLLER_PATH} from "./AuthActionsFactory";


export function orderSendAction(data, cart) {
    debugger
    const request = {
        email: data.email,
        phone: data.phoneNumber,
        firstName: data.firstName,
        secondName: data.secondName,
        patronymic: data.patronymic,
        comment: data.comment,
        address: {
            postalOffice: data.postalOffice,
            city: data.city,
            house: data.house,
            street: data.street,
            apartment: data.apartment,
        },
        cartLines: cart.map(cartLine => {
            return {
                productId: cartLine.productId,
                quantity: cartLine.count
            }
        }),
    };
    console.log(request);
    return dispatch => {
        let path = `${DOMAIN}Order/CreateOrder`;
        requestDecorator(
            path,
            "POST",
            request,
            true
        );
    }
}

//if user authenticated telling server refresh cart state for backUp and device sync
// <param name="authFlag", type=bool>
// <param name="product",
// type = product: {
//     productId: 777,
//     productName: "Name",
//     productPrice: 2.2,
//     productImg: "https//",
//     count: 2,
// }>
export function addToCardAction(cartLine) {
    debugger
    return async dispatch => {
        dispatch({
            type: CART_ADD_PRODUCT,
            payload: cartLine,
        });
        // dispatch(
        //     {type: SWITCH_MINI_CART_FLAG}
        // );
        if (getAuthFlag()) {
            requestDecorator(
                `${DOMAIN}/Cart/Add`,
                "post",
                {
                    productId: cartLine.productId, //todo
                    count: cartLine.count
                },
                r => console.log(r),
                e => console.log(e)
            )
        }
    }
}

export function decrementProductsInCartAction(productId) {
    debugger
    return async dispatch => {
        dispatch({
            type: CART_DECREMENT_PRODUCT_COUNT,
            payload: {productId: productId},
        });
        // dispatch(
        //     {type: SWITCH_MINI_CART_FLAG}
        // );
        if (getAuthFlag()) {
            requestDecorator(
                `${DOMAIN}/Cart/Add`,
                "post",
                {
                    productId, //todo
                },
                r => console.log(r),
                e => console.log(e)
            )
        }
    }
}

export function removeFromCardAction(productId) {
    return async dispatch => {
        dispatch({
            type: CART_REMOVE_PRODUCT,
            payload: {productId: productId}
        });
        if (getAuthFlag()) {
            requestDecorator(
                `${DOMAIN}/Cart/Remove`,
                "post",
                {
                    productId,
                },
                r => console.log(r),
                e => console.log(e)
            );
        }
    }
}

// <param name="authFlag", type=bool>
// <param name="product",
// type = product: {
//     productId: 777,
//     productName: "Name",
//     productPrice: 2.2,
//     productImg: "https//",
//     count: 2,
// }>
export function setToCardAction(cartLine) {
    return async dispatch => {
        dispatch({
            type: CART_SET_PRODUCT_COUNT,
            payload: {product: cartLine}
        });
        if (getAuthFlag()) {
            await requestDecorator(
                `${DOMAIN}/Cart/Set`,
                "post",
                {
                    productId: cartLine.id,
                    count: cartLine.count
                },
                r => console.log(r),
                e => console.log(e)
            );
        }
    }
}

//Function used for initial state by storage with no params(false) will not try get data from server
export function initialStateCartAction() { //
    return dispatch => {
        debugger
        let cart;
        try {
            cart = localStorage.getCart();
            if (Array.isArray(cart) && cart.length > 0) { //if not arr, scip second expression
                dispatch({type: SET_CART, payload: cart});
                return
            }
        } catch (error) {
            log(`InitialStateCartException, probably upon attempt get cart from ls and parse, 
            cart value = ${cart}`, error);
        }
        if (localStorage.getAuthStatus()) { //todo init order
            requestDecorator(
                `${DOMAIN}/Cart/Get`, //todo
                "GET",
                {
                    userId: localStorage.get("userId")
                },
                (response) => { // raw response todo try using mapper, cartId, routing
                    debugger
                    console.log(response);
                    const payload = response.cart;
                    dispatch({type: SET_CART, payload});
                },
                (error) => console.log(error)
            );
        }
    }
}

//get cart from back if ls and state is empty
export function getCartBackUpAction(userId, cartId = null) {
    return async dispatch => {
        requestDecorator(
            `${DOMAIN}/Cart/Get`, //todo
            "GET",
            {
                userId
            },
            (response) => { // raw response todo try using mapper, cartId, routing
                debugger
                console.log(response);
                const payload = response.cart;
                dispatch({type: SET_CART, payload});
            },
            (error) => console.log(error)
        );
    }
}