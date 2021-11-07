import React from "react";
import {initialState} from "../InitialState";
import {
    SWITCH_AUTH_FORM_BACKGROUND_FLAG,
    SWITCH_BURGER_FORM_FLAG,
    SWITCH_LOGIN_FORM_FLAG,
    SWITCH_REGISTRATION_FORM_FLAG,
    SWITCH_THANKFULNESS_POPUP_FLAG
} from "../ActionsEnum";


export function UIReducer(state = initialState.uiFlags, action) {
    switch (action.type) {
        case SWITCH_LOGIN_FORM_FLAG:
            return {...state, loginFormFlag: !state.loginFormFlag}
        case SWITCH_REGISTRATION_FORM_FLAG:
            return {...state, registrationFormFlag: !state.registrationFormFlag}
        case SWITCH_BURGER_FORM_FLAG:
            return {...state, leftBurgerFlag: !state.leftBurgerFlag}
        case SWITCH_THANKFULNESS_POPUP_FLAG:
            return {...state, thankfulnessPopUpFlag: !state.thankfulnessPopUpFlag}
        case SWITCH_AUTH_FORM_BACKGROUND_FLAG:
            return {...state, signInUpHolder: !state.signInUpHolder}
        default:
            return state;
    }
}