import React from "react";
import {NavLink, Route, Switch, useHistory, useParams} from "react-router-dom";
import '../../styles/ProductPage.css'
import {useDispatch,} from "react-redux";
import {getAndRouteProductPage,} from "../../redux/ProductsActionsFactory";
import {ProductPageComments} from "./ProductPageComments";
import {ProductInfoPage} from "./ProductInfoPage";
import {ProductDopInfoPage} from "./ProductDopInfoPage";
import {useLocation} from 'react-router-dom'

export function ProductPageProvider(productInfoViewModel) {
    const dispatcher = useDispatch();
    const brHistory = useHistory();
    const loc = useLocation();
    let productId = loc.state.productId;
    if (productInfoViewModel.id != productId) {
        dispatcher(getAndRouteProductPage({productId, brHistory}));
    }
    return (
        <div className="ppMainBlock">
            <div className='pp-naw-block'>
                <h1 className="h0">{productInfoViewModel.name}</h1>
                <div className="productPageNavigation">
                    <NavLink to={{
                        pathname: "/ProductInfoPage/",
                        state: {productId: productInfoViewModel.id},
                    }}>
                        Main page
                    </NavLink>
                    <NavLink to={{
                        pathname: "/ProductInfoPage/DopInfo/",
                        state: {productId: productInfoViewModel.id},
                    }}>
                        Dop info
                    </NavLink>
                    <NavLink to={{
                        pathname: "/ProductInfoPage/Comments/",
                        state: {productId: productInfoViewModel.id},
                    }}>
                        Comments
                    </NavLink>
                    <NavLink to={{
                        pathname: "/ProductInfoPage/Comments/",
                        state: {productId: productInfoViewModel.id},
                    }}>
                        consult
                    </NavLink>
                </div>
            </div>
            <Switch>
                <Route path="/ProductInfoPage/Comments/">
                    <ProductPageComments {...productInfoViewModel}/>
                </Route>
                <Route path="/ProductInfoPage/DopInfo/">
                    <ProductDopInfoPage {...productInfoViewModel}/>
                </Route>
                <Route path="/ProductInfoPage/">
                    <ProductInfoPage {...productInfoViewModel}/>
                </Route>
            </Switch>
        </div>
    );
}
