import {AuthorisedRequest} from "../../requests/Requests";
import {
    CART_ADD_PRODUCT,
    CART_REMOVE_PRODUCT,
    CART_SET_PRODUCT_COUNT,
    DOMAIN,
    SET_CART,
    SWITCH_MINI_CART_FLAG
} from "../Consts";

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
