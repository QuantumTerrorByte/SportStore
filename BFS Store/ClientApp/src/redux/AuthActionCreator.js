import React from "react";
import {PRODUCTS_CONTROLLER_NAME} from "./ActionsEnum";
import $ from "jquery";
import {store} from "../index";
import * as DOMAIN from "domain";


export function auth(form) {
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${PRODUCTS_CONTROLLER_NAME}GetProductPage`,
            type: "GET",
            data: {form},
        }).done(response => {
            console.log(response)
            dispatch({
                type: "",
                payload: {...response, productAmountOrderInput: 1, maxOrderSizeFlag: false}
            });
        });
    }
}