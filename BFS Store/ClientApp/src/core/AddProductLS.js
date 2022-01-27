/*CartModel = {
    id: 777,
    cartLine: {
        product: { //from simple view
            productId: 777,
            productImg: "asd",
            productPrice:
            productName: "hello"
        },
        count: 2
    }
}*/
export function addProductLS(product, count = 1) {
    let cart = JSON.parse(localStorage.getItem("cart"));
    let cartLine = cart.filter(e => e.product.id === product.id);
    if (cartLine != undefined) {
        if (cartLine.length != 1) {
            throw Error
        }
        cartLine[0].count += count;
    } else {
        cart.push({
            product,
            count,
        });
    }
    localStorage.setItem("cart", JSON.stringify(cart));
}

