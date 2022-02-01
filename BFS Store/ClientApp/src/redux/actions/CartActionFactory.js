import {AuthorisedRequest} from "../../requests/Requests";
import {
    CART,
    CART_ADD_PRODUCT,
    CART_REMOVE_PRODUCT,
    CART_SET_PRODUCT_COUNT,
    DOMAIN,
    SET_CART,
    SWITCH_MINI_CART_FLAG
} from "../Consts";
import {log} from "../../core/log";
import {store} from "../../index";

//if user authenticated telling server refresh cart state for backUp and device sync
export function addToCardAction(authFlag, product, count = 1) {
    debugger
    return async dispatch => {
        dispatch({
            type: CART_ADD_PRODUCT,
            payload: {product, count}
        });
        dispatch(
            {type: SWITCH_MINI_CART_FLAG}
        );
        if (authFlag) {
            AuthorisedRequest(
                `${DOMAIN}/Cart/Add`,
                "post",
                {
                    productId: product.productId, //todo
                    count
                },
                r => console.log(r),
                e => console.log(e)
            )
        }
    }
}


export function setStateAction(userId, cartId = null) {
    return async dispatch => {
    }
}


export function removeFromCardAction(authFlag, product, count = 1) {
    return async dispatch => {
        dispatch({
            type: CART_REMOVE_PRODUCT,
            payload: {product, count}
        });
        if (authFlag) {
            AuthorisedRequest(
                `${DOMAIN}/Cart/Remove`,
                "post",
                {
                    productId: product.id,
                    count
                },
                r => console.log(r),
                e => console.log(e)
            );
        }
    }
}

export function setToCardAction(authFlag, product, count = 1) {
    return async dispatch => {
        dispatch({
            type: CART_SET_PRODUCT_COUNT,
            payload: {product, count}
        });
        if (authFlag) {
            await AuthorisedRequest(
                `${DOMAIN}/Cart/Set`,
                "post",
                {
                    productId: product.id,
                    count
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
            AuthorisedRequest(
                `${DOMAIN}/Cart/Get`, //todo
                "GET",
                {
                    userId:localStorage.get("userId")
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
        AuthorisedRequest(
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