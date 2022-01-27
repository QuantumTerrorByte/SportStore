import React from 'react';
import {Home} from './components/Home';
import {NavLink, Route, Switch, useHistory} from "react-router-dom";
import {useDispatch, useSelector} from "react-redux";
import Header from "./components/header/Header";
import {RegistrationReduxForm} from "./components/forms/RegistrationAndEditProfileForm";
import {UserProfilePage} from "./components/userProfile/UserProfilePage";
import {LoginReduxForm} from "./components/forms/LoginForm";
import {signIn, signUp} from "./redux/actions/AuthActionsFactory";
import {
    SWITCH_AUTH_FORM_BACKGROUND_FLAG
} from "./redux/Consts";
import styles from './styles/Home.module.css'
import formStyles from './styles/SignUpSignInProfileEdit.module.css'
import Footer from "./components/Footer";
import {ProductPageProvider} from "./components/ProductPageComponents/ProductPageProvider";
import {CartMini} from "./components/header/CartMini";


export default function App(props) {
    const state = useSelector(state => state)
    const browserHistory = useHistory();
    const dispatch = useDispatch();
    const isAuth = state.userData.isAuthenticated;
    const className = state.uiFlags.signInUpHolder ? styles.authFormHolder : styles.none;
    const formHolder = () => dispatch({type: SWITCH_AUTH_FORM_BACKGROUND_FLAG});

    return (<div className={styles.main}>
            <div className="top-top-panel">Акция</div>
            <Header state={state}/>

            <Switch>
                <Route exact path='/SignIn'>
                    <div onClick={formHolder} className={className}>
                        <div onClick={(e) => e.stopPropagation()}>
                            <LoginReduxForm styles={formStyles}
                                            onSubmit={(e) => dispatch(
                                                signIn({browserHistory, ...e}))}/>
                        </div>
                    </div>
                </Route>
                <Route exact path='/SignUp'>
                    <div onClick={formHolder} className={className}>
                        <div onClick={(e) => e.stopPropagation()}>
                            <RegistrationReduxForm styles={formStyles}
                                                   onSubmit={(e) => dispatch(
                                                       signUp(browserHistory, e))}/>
                        </div>
                    </div>
                </Route>
                <Route exact path='/ThankYou'>
                    <div onClick={formHolder} className={className}>
                        <div className={formStyles.thanks}>
                            <NavLink to='/' onClick={formHolder}>Thanks for your registration, happy buying^^</NavLink>
                        </div>
                    </div>
                </Route>
            </Switch>
            <Switch>
                <Route path='/ProductInfoPage/'>
                    <ProductPageProvider {...state.productPageViewModel}/>
                </Route>
                <Route path='/UserProfilePage/'>
                    <UserProfilePage {...state.userData}/>
                </Route>
                <Route path='/'>
                    <Home {...state.catalogPage} />
                </Route>
            </Switch>
            <Footer styles={styles}></Footer>
        </div>
    );
}
// onClick={() => dispatch({type: SWITCH_THANKFULNESS_POPUP_FLAG})}
