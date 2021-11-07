import React from "react";
import {
    DOMAIN,
    SWITCH_AUTH_FORM_BACKGROUND_FLAG,
    USER_AUTH_CHANGE_STATE,
    USER_DELETE,
    USER_LOGIN,
    USER_REGISTRATION,
    USER_UPDATE
} from "./ActionsEnum";
import $ from "jquery";
import {useHistory} from "react-router-dom";


export const AUTH_CONTROLLER_PATH = "api/Auth/";

export function signIn({browserHistory, email, password}) {
    let request = JSON.stringify({email, password});
    debugger
    return dispatch => {
        $.ajax("https://localhost:5005/api/Auth/SignIn", {
            type: "POST",
            dataType: "json",
            contentType: "application/json",
            data: request,
            error: (arg1, arg2, arg3) => {
                console.log(arg1);
                console.log(arg2);
                console.log(arg3);
            },
        }).done(response => {
            console.log(response)
            dispatch({type: USER_LOGIN, payload: response});
            browserHistory.push('/ThankYou');
        });
    }
}


export function signOut({browserHistory}) {
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${AUTH_CONTROLLER_PATH}SignOut`,
            type: "POST",
            dataType: "json",
            contentType: "application/json",
            data: null,
            error: (arg1, arg2, arg3) => {
                console.log(arg1);
                console.log(arg2);
                console.log(arg3);
            },
        }).done(response => {
            dispatch(USER_AUTH_CHANGE_STATE);
            browserHistory.goBack();
        });
    }
}

export function signUp(browserHistory, ...form) {
    debugger
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${AUTH_CONTROLLER_PATH}SignUp`,
            type: "POST",
            data: JSON.stringify(form),
            error: (arg1, arg2, arg3) => { //todo alert
                console.log(arg1)
                console.log(arg2)
                console.log(arg3)
                debugger
            },
        }).done(response => {
            dispatch({type: USER_REGISTRATION, payload: response});
            browserHistory.push('/ThankYou');
        });
    }
}

export function editUserData(form) {
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${AUTH_CONTROLLER_PATH}Edit`,
            type: "POST",
            data: JSON.stringify(form),
            error: (arg1, arg2, arg3) => {
                console.log(arg1);
                console.log(arg2);
                console.log(arg3);
            },
        }).done(response => {
            dispatch({type: USER_UPDATE, payload: response});
        });
    }
}

export function deleteAccount({browserHistory, userId}) {
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${AUTH_CONTROLLER_PATH}Delete?${userId}`,
            type: "POST",
            data: null,
            error: (arg1, arg2, arg3) => {
                console.log(arg1);
                console.log(arg2);
                console.log(arg3);
            },
        }).done(response => {
            dispatch(USER_DELETE);
        });
    }
}
