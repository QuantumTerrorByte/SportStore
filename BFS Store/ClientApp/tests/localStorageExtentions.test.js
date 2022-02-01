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
