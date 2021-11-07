import React from "react";
import {initialState} from "../InitialState";
import {
    USER_AUTH_CHANGE_STATE,
    USER_DELETE,
    USER_LOGIN,
    USER_LOGOUT,
    USER_REGISTRATION,
    USER_UPDATE
} from "../ActionsEnum";

const userMapper = (responce) => {
    return {userId: responce.id, userEmail: responce.email, userPhoneNumber: responce.phoneNumber, ...responce}
};

export function UserDataReducer(state = initialState.userData, action) {
    // console.log(action)
    switch (action.type) {
        case USER_REGISTRATION:
            return {...state, ...userMapper(action.payload), thankfulnessPopUpFlag: true};
        case USER_LOGIN:
            return {...state, ...userMapper(action.payload), isAuthenticated: true};
        case USER_UPDATE:
            return {...state, ...userMapper(action.payload)};
        case USER_LOGOUT:
            return {...state, userData: {...state, isAuthenticated: false}};
        case USER_DELETE:
            return initialState;

        default:
            return state;
    }
}