//return value object by key or null if key not finded
import {AUTH_FLAG, CART} from "../redux/Consts";
import {log} from "./log";

export function methodsExtensions() {
    Storage.prototype.get = function (key) {
        let result = this.getItem(key);
        try {
            result = JSON.parse(result);
        } catch (error) {
            log(`Exception when trying parce value ${result} from local storage with requested key ${key}`, error);
        }
        return result;
    };
    Storage.prototype.set = function (key, value) {
        try {
            value = JSON.stringify(value);
            this.setItem(key, value);
        } catch (error) {
            log(`Exception when trying set value in local storage, key = ${key}, value = ${value}, 
            type = ${typeof value}`, error);
            return false;
        }
        return value;
    };
    //get array from local store, and add arg value(s), then return arr to the ls
    Storage.prototype.addValue = function (arrKey, value, inTheEndOfArr = true) {
        const target = this.get(arrKey);
        if (!Array.isArray(target)) { //todo get this value and replace in to special arr(critical for orders and logs)
            log("problems in storage.addValue method, probably wrong key");
            return null;
        }
        if (inTheEndOfArr) {
            target.push(value);
        } else {
            target.unshift(value);
        }
        this.set(arrKey, target);
        return target;
    };
    Storage.prototype.getAuthStatus = function () {
        const result = this.get(AUTH_FLAG) === null ? false : true;
        return result;
    };
    // [{cartLine:
    //     product: {
    //         productId: 555,
    //         productShortDescription: "Now foods vitamin d3 2000mg with carotene",
    //         productPrice: 2.1,
    //         productImg: "https://s3.images-iherb.com/mav/mav16261/v/15.jpg",
    //     },
    //     count: 2
    // }];
    Array.prototype.getCartPrice = () => {
        let result = 0;
        this.forEach(e => result += e.product.productPrice * e.count);
        return result;
    };

    Storage.prototype.getCart = function () {
        return localStorage.get(CART);
    }

    Storage.prototype.setCart = function (cart) {
        if (Array.isArray(cart)) {
            localStorage.set(CART, cart);
        } else {
            throw new Error(`trying set wrong value in to cart, value:${cart}`);
        }
        return cart;
    }

    Storage.prototype.addProducts = function (cartLines) {

    }
    Storage.prototype.removeProduct = function (productId) {

    }
    Storage.prototype.setProductCount = function (cartLines) {

    }
    Date.prototype.timeNow = function () {
        return ((this.getHours() < 10) ? "0" : "")
            + this.getHours() + ":" + ((this.getMinutes() < 10) ? "0" : "")
            + this.getMinutes() + ":" + ((this.getSeconds() < 10) ? "0" : "") + this.getSeconds();
    }
}


function extensionsMethodsTests() {
    debugger
    let x = localStorage.set("test", "testValue1");
    console.log("set");
    console.log(x);
    debugger
    let y = localStorage.get("test");
    debugger
    console.log("get");
    console.log(y);
    localStorage.setItem("testArr", JSON.stringify([{name: "oleg"}, {name: "vasa"}, {name: "semen"}]));
    debugger
    let z = localStorage.addValue("testArr", {name: "DEMON", status: "otec"});
    debugger
    console.log("addValue");
    console.log(z);

    let reff1 = localStorage.getAuthStatus();
    debugger
    let reff2 = localStorage.set("authFlag", true);
    debugger
    let reff3 = localStorage.getAuthStatus();
    debugger
    console.log(reff1);
    console.log(reff2);
    console.log(reff3);
}
