import React from "react";
import {initialState} from "../InitialState";
import {SWITCH_MINI_CART_FLAG} from "../Consts";

// uiFlags:
// { loginFormFlag
// registrationFormFlag
// leftBurgerFlag
// thankfulnessPopUpFlag }

export function switchMiniCartFlagAction() { //todo animation
    return async dispatch => {
        dispatch({type: SWITCH_MINI_CART_FLAG});
        setTimeout(() => dispatch({type: SWITCH_MINI_CART_FLAG}), 30000);
    }
}

export function UserDataReducer(state = initialState.userData, action) {
    switch (action.type) {

        default:
            return state;
    }
}
