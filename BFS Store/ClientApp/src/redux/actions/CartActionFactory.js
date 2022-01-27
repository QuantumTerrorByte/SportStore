import {AuthorisedRequest} from "../../requests/Requests";
import {CART_ADD_PRODUCT, CART_REMOVE_PRODUCT, CART_SET_PRODUCT_COUNT, DOMAIN} from "../Consts";

//if user authenticated telling server refresh cart state for backUp and device sync
export function addToCardAction(authFlag, product, count = 1) {
    return async dispatch => {
        dispatch({
            type: CART_ADD_PRODUCT,
            payload: {product, count}
        });
        if (authFlag) {
            await AuthorisedRequest(
                `${DOMAIN}/Cart/Add`,
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

export function removeFromCardAction(authFlag, product, count = 1) {
    return async dispatch => {
        dispatch({
            type: CART_REMOVE_PRODUCT,
            payload: {product, count}
        });
        if (authFlag) {
            await AuthorisedRequest(
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
