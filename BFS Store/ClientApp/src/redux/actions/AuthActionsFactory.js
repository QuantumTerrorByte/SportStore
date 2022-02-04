import React from "react";
import {
    AUTH_DOMAIN,
    DOMAIN,
    USER_DELETE,
    USER_LOGIN,
    USER_REGISTRATION,
    USER_UPDATE
} from "../Consts";
import $ from "jquery";
import {requestDecorator} from "../../requests/Requests";


export const AUTH_CONTROLLER_PATH = "/Auth";

// send log pass request from redux-form, save user data in redux
// and JWT in localStorage on success and turn on singIn flag
// response = {
//     access_token,
//     userInfo = {
//         Email,
//         Id,
//         UserName,
//         PhoneNumber,
//     }
export function signIn({browserHistory, email, password}) {
    let payload = JSON.stringify({email, password});
    debugger
    return dispatch => {
        $.ajax(`${AUTH_DOMAIN}${AUTH_CONTROLLER_PATH}/SignInCostumers`, {
            type: "post",
            dataType: "json",
            contentType: "application/json",
            data: payload,
        }).done(response => {
            debugger
            console.log(response);
            localStorage.setItem("JWT", response.access_token);
            dispatch({type: USER_LOGIN, payload: response.userInfo});
            browserHistory.push('/ThankYou');
        }).fail((jqXHR, exception) => {
            console.log(jqXHR.status);
            console.log(jqXHR.responseText);
        });
    }
}

export function signUp(browserHistory, form) {
    debugger
    return async dispatch => {
        $.ajax({
            url: `${AUTH_DOMAIN}${AUTH_CONTROLLER_PATH}/SignUp`,
            type: "POST",
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(form),
        }).done(response => {
            dispatch({type: USER_REGISTRATION, payload: response});
            browserHistory.push('/ThankYou');
        }).fail((jqXHR, exception) => {
            console.log(jqXHR.status);
            console.log(jqXHR.responseText);
        });
        ;
    }
}

export function editUserData(form) {
    debugger
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${AUTH_CONTROLLER_PATH}/Edit`,
            type: "POST",
            data: JSON.stringify(form),
            dataType: "json",
            contentType: "application/json",
        }).done(response => {
            debugger
            dispatch({type: USER_UPDATE, payload: response});
        }).fail((jqXHR, exception) => {
            console.log(jqXHR.status);
            console.log(jqXHR.responseText);
        });
    }
}


export function deleteAccount({browserHistory, userId}) {
    return async dispatch => {
        $.ajax({
            url: `${AUTH_DOMAIN}${AUTH_CONTROLLER_PATH}/Delete?${userId}`,
            type: "POST",
            dataType: "json",
            data: null,
        }).done(response => {
            dispatch(USER_DELETE);
        }).fail((jqXHR, exception) => {
            console.log(jqXHR.status);
            console.log(jqXHR.responseText);
        });
    }
}

export function TestAction() {
    debugger
    return async dispatch => {
        requestDecorator(
            `${DOMAIN}/Costumers/AddLike`,
            "post",
            1,
            r => console.log(r),
            e => console.log(e))
    }
}