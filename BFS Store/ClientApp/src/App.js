import React from 'react';
import {Home} from './components/Home';
import {Route, Switch} from "react-router-dom";
import {ProductInfoPage} from "./components/ProductInfoPage";
import {useSelector} from "react-redux";
import {SignIn} from "./components/Registration";
import Header from "./components/Header";
import {auth} from "./redux/ActionFactory";
import {LoginReduxForm} from "./components/forms/LoginForm";
import styles from './styles/Home.css'
import {RegistrationAndEditProfileReduxForm} from "./components/forms/RegistrationAndEditProfileForm";

export default function App() {
    const state = useSelector(state => state)
    return (
        <div className={styles.main}>
            <div className="top-top-panel">Акция</div>
            <Header/>
            <LoginReduxForm onSubmit={()=>console.log()}/>
            <Switch>
                <Route path='/Info/:productId'>
                    <ProductInfoPage productInfoViewModel={state.productPageViewModel}/>
                </Route>
                if(state.showRegistration){                }
                <Route path='/SignIn'>
                    <RegistrationAndEditProfileReduxForm onSubmit={(e)=>console.log(e)}/>
                </Route>
                <Route path='/' >
                    <Home state={state}/>
                </Route>
            </Switch>
        </div>
    );
}
