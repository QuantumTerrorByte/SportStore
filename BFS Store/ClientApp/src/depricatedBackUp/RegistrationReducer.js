import React from "react";
import {initialState} from "../redux/InitialState";
import {
    SET_REGISTRATION_EMAIL_INPUT,
    SET_REGISTRATION_NAME_INPUT, SET_REGISTRATION_PASSWORD_CONFIRMED_INPUT,
    SET_REGISTRATION_PASSWORD_INPUT,
    SET_REGISTRATION_PHONE_INPUT
} from "../redux/ActionsEnum";

export const RegistrationReducer = (state = initialState.registrationPage, action) => {
    // console.log(action)
    switch (action.type){
        case SET_REGISTRATION_NAME_INPUT:
            return {
                ...state,nameInput: action.payload
            }
        case SET_REGISTRATION_EMAIL_INPUT:
            return {
                ...state,emailInput: action.payload
            }
        case SET_REGISTRATION_PHONE_INPUT:
            return {
                ...state,phoneInput: action.payload
            }
        case SET_REGISTRATION_PASSWORD_INPUT:
            return {
                ...state,passwordInput: action.payload
            }
        case SET_REGISTRATION_PASSWORD_CONFIRMED_INPUT:
            return {
                ...state,passwordConfirmInput: action.payload
            }


        default:
            return state;
    }
}
