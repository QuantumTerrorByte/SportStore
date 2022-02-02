import {log} from "./log";

export function getCartPrice(cart) {
    let result = 0;
    debugger
    if (Array.isArray(cart)) {
        cart.forEach(prod => result += prod.productPrice * prod.count);
    } else {
        log(`error in getCartPrice with arg: ${cart}`);
    }
    return result;
}