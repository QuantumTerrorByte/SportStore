import React from "react";
import {Product} from "./Product";
import Pagination from "./Pagination";
import {useDispatch} from "react-redux";
import {addProducts} from "../redux/ProductsActionsFactory";
import '../styles/ProductBlockForCostumers.css'

export default function Products({products, filters}) {
    const dispatch = useDispatch();
    console.log(products)
    return (
        <div>
            <div className="products-output-area">
                {products.productsList.map(product => <Product {...product} key={product.id}/>)}
            </div>
            <button onClick={() => dispatch(addProducts(products.currentPage))}>
                Upload MORE
            </button>
            <Pagination paging={products.pagination} currentPage={products.currentPage}/>
        </div>)
}
//

// function mapStateToProps(state) {
//     console.log("from state")
//     console.log(state)
//     return state;
// }
//
// export default connect(mapStateToProps)(Products);