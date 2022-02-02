const {CART} = require("../src/redux/Consts");
const {myFunc} = require("../src/TProdId");
const {methodsExtensions} = require("../src/core/methodsExtensions");

describe("localStorage extensions methods", () => {
    methodsExtensions();

    test("getCart should return storage array value by key CART (return array) && " +
        "setCart should set Array in to storage by key CART", () => {

        localStorage.setCart([{name: "first"}, {name: "second"}]);
        expect(localStorage.getCart()).toEqual([{name: "first"}, {name: "second"}]);

    });
    test("setCart can throw error if value not arr", () => {
        // methodsExtensions();
        let canThrowCrutch;
        try {
            localStorage.setCart({name: "first"});
            canThrowCrutch = false;
        } catch (e) {
            canThrowCrutch = true;
        }
        expect(canThrowCrutch).toBe(true);
    })
})


describe("array  extensions methods", () => {
    methodsExtensions();
    test("can summarise", () => {
        expect([{age: 10}, {age: 12}, {age: 3}].sum(e => e.age)).toBe(25);
    });

    test("arr remove", () => {
        let cart = [
            {productId: 1, name: "name1", age: 15},
            {productId: 2, name: "name2", age: 20},
            {productId: 3, name: "name3", age: 25},
            {productId: 4, name: "name4", age: 33},
        ];
        let result = [
            {productId: 1, name: "name1", age: 15},
            {productId: 2, name: "name2", age: 20},
            {productId: 4, name: "name4", age: 33},
        ];
        let testElem = cart.find(e => e.productId === 3);
        expect(testElem).toEqual({productId: 3, name: "name3", age: 25});
        expect(cart.indexOf(testElem)).toEqual(2);
        expect(cart.length).toEqual(4);
        cart.splice(cart.indexOf(testElem), 1);
        expect(cart.length).toEqual(3);
        expect(cart).toEqual(result);
    });


});