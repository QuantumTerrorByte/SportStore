import React from "react";
import {DOMAIN, USER_LOGIN, USER_REGISTRATION} from "./ActionsEnum";
import $ from "jquery";
import {initialState} from "./InitialState";

// uiFlags:
// { loginFormFlag
// registrationFormFlag
// leftBurgerFlag
// thankfulnessPopUpFlag }

export function UserDataReducer(state = initialState.userData, action) {
    switch (action.type) {

        default:
            return state;
    }
}
