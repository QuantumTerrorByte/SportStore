import React from "react";
import {initialState} from "../InitialState";

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
