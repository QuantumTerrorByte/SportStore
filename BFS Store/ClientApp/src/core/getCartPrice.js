export function getCartPrice(props) {
    let result = 0;
    props.cart.forEach(e => result += e.product.productPrice * e.count);
    return result;
}