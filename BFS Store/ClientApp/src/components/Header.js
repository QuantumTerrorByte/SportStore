import React from "react";
import '../styles/Header.css'
import {NavLink} from "react-router-dom";


export default function Header() {

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
                    <div className="header-language">
                        UA
                    </div>
                    <div className="header-language">
                        EN
                    </div>
                </div>
                <div className="header-login-block">
                    <div className="header-login-icon"></div>
                    <input className="header-login-input" placeholder="login"/>
                    <input className="header-login-input" placeholder="password"/>
                </div>
                <div>
                    <button>SignUp</button>
                    <NavLink to='/SignIn'>SignIn</NavLink>
                </div>
                <div className="header-registration-block"></div>
                <div className="header-cart-block">
                    <div className="header-cart-icon"></div>
                    <div className="header-cart-items">11</div>
                </div>
            </div>
        </div>
    )
}