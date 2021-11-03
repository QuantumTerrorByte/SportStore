import React from 'react';
import {BrowserRouter, useHistory} from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';
import {applyMiddleware, compose, createStore} from 'redux';
import {rootReducer} from "./redux/rootReducer";
import {Provider} from 'react-redux';
import {render} from 'react-dom';
import thunk from 'redux-thunk';
import {setCurrentPage, uploadCategoriesAndBrands} from "./redux/ActionFactory";
import './styles/Home.css'


export const store = createStore(rootReducer, compose(
        applyMiddleware(thunk),
        window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
    ));

store.dispatch(setCurrentPage(1));
store.dispatch(uploadCategoriesAndBrands());


const app = (
    <Provider store={store}>
        <BrowserRouter>
            <App/>
        </BrowserRouter>
    </Provider>
)

render(app, document.getElementById('root'));
registerServiceWorker();


// const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');