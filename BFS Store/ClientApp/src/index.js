import React from 'react';
import {BrowserRouter} from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';
import {applyMiddleware, compose, createStore} from 'redux';
import {rootReducer} from "./redux/reducers/rootReducer";
import {Provider} from 'react-redux';
import {render} from 'react-dom';
import thunk from 'redux-thunk';
import {
    setCurrentPage,
    uploadCategoriesAndBrands
} from "./redux/actions/ProductsActionsFactory";
import './styles/Home.module.css';
import {initialStateCartAction} from "./redux/actions/CartActionFactory";


// export const store = function () {
//     const result = createStore(rootReducer, compose(
//         applyMiddleware(thunk),
//         window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
//     ));
//     //!!!!!!
//     return result;
// }();
export const store = createStore(rootReducer, compose(
    applyMiddleware(thunk),
    // window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
));


store.dispatch(initialStateCartAction());
store.dispatch(uploadCategoriesAndBrands());
store.dispatch(setCurrentPage(1));
store.dispatch({type: ""});


const app = (
    <Provider store={store}>
        <BrowserRouter>
            <App/>
        </BrowserRouter>
    </Provider>
);

render(app, document.getElementById('root'));
console.timeEnd("store");
registerServiceWorker();

// const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');