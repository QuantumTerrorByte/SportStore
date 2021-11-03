import React from 'react';
import {Home} from './components/Home';
import {Route, Switch} from "react-router-dom";
import {ProductInfoPage} from "./components/ProductInfoPage";
import {useSelector} from "react-redux";

export default function App() {
    const state = useSelector(state => state)
    return (
        <div>
            <div className="top-top-panel">Акция</div>
            <Switch>
                <Route path='/Info/:productId'>
                    <ProductInfoPage productInfoViewModel={state.productPageViewModel}/>
                </Route>
                <Route path='/' >
                    <Home state={state}/>
                </Route>
            </Switch>
        </div>
    );
}
