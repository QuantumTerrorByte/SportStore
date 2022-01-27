import React from "react";
import '../../styles/Header.css'
import {NavLink, useHistory} from "react-router-dom";
import {useDispatch, useSelector} from "react-redux";
import {SWITCH_AUTH_FORM_BACKGROUND_FLAG, USER_AUTH_CHANGE_STATE} from "../../redux/Consts";
import {CartMini} from "./CartMini";


export default function Header() {
    const browserHistory = useHistory();
    const dispatch = useDispatch();
    const state = useSelector(s => s);
    return (
        <div className="header-block-holder">
            <div className="header-block">
                <div className="header-burger"/>
                <NavLink to='/' className="header-logo"/>
                <div className="header-nav-block">
                    <div className="header-nav-icon"/>
                    <div className="header-nav-text">Каталог</div>
                </div>
                <form className="header-search-block">
                    <input className="header-search"/>
                    <button className="header-search-button">Найти</button>
                </form>
                <div className="header-language-block">
                    <div className="header-language">
                        RU
                    </div>
                    <div className="header-language mid">
                        UA
                    </div>
                    <div className="header-language">
                        EN
                    </div>
                </div>

                <div className="header-login-block">
                    <div className="header-login-icon"/>
                    {state.userData.isAuthenticated ?
                        <div>
                            <NavLink className="devLinksDecor" to="/UserProfilePage">Profile</NavLink>
                            <span className="devLinksDecor"
                                  onClick={() => {
                                      dispatch({type: USER_AUTH_CHANGE_STATE});
                                      browserHistory.goBack();
                                  }}>SignOut</span>
                        </div> :
                        <NavLink className="devLinksDecor" to='/SignIn'
                                 onClick={() => dispatch({type: SWITCH_AUTH_FORM_BACKGROUND_FLAG})}>SignIn</NavLink>}
                    <NavLink className="devLinksDecor" to='/SignUp'
                             onClick={() => dispatch({type: SWITCH_AUTH_FORM_BACKGROUND_FLAG})}>SignUp</NavLink>
                </div>
                <div className="header-registration-block"/>
                <div className="header-cart-block">
                    {(state.cart.length > 0 && state.uiFlags.cartMiniFlagUI) ? <CartMini cart={state.cart}/> : null}
                    <div className="header-cart-icon"/>
                    <div className="header-cart-items">11</div>
                </div>
            </div>
        </div>
    )
}

// const styles = {
//     loginForm: "header-login-block",
//     inputBlockErrorText: "header-login-icon",
//     inputBlockErrorInput: "header-login-input",
//     inputBlock: "header-login-input",
// }
// styles for FormInput
// inputBlock
// inputBlockErrorText
// inputBlockErrorInput
// loginForm

// <div className="header-login-block">
//     <div className="header-login-icon"/>
//     <input className="header-login-input" placeholder="login"/>
//     <input className="header-login-input" placeholder="password"/>
// </div>