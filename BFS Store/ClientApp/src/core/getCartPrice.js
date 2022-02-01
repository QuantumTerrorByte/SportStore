import {log} from "./log";

export function getCartPrice(cart) {
    let result = 0;
    debugger
    if (Array.isArray(cart)) {
        cart.forEach(e => result += e.product.productPrice * e.count);
    } else {
        log(`error in getCartPrice with arg: ${cart}`);
    }
    return result;
}