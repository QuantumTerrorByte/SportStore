import React from "react";
import {initialState} from "../InitialState";
import {SWITCH_MINI_CART_FLAG} from "../Consts";

// uiFlags:
// { loginFormFlag
// registrationFormFlag
// leftBurgerFlag
// thankfulnessPopUpFlag }

export function switchMiniCartFlagAction() { //todo animation
    debugger
    return async dispatch => {
        dispatch({type: SWITCH_MINI_CART_FLAG});
    }
}

