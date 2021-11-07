import React from "react";
import {
    ADD_PRODUCTS,
    DECREMENT_PP,
    DOMAIN,
    INCREMENT_PP,
    PRODUCTS_CONTROLLER_NAME,
    REFRESH_PRODUCT_PAGE,
    REFRESH_PRODUCTS,
    SET_CURRENT_PAGE,
    SET_FILTER_BRAND,
    SET_FILTER_CATEGORY1,
    SET_FILTER_CATEGORY2,
    SET_FILTER_MAX_PRICE,
    SET_FILTER_MIN_PRICE,
    SET_FILTER_SORT,
    UPLOAD_CATEGORIES_AND_BRANDS,
} from "./ActionsEnum";
import $ from "jquery";
import {store} from "../index";


export function auth(form) {
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${PRODUCTS_CONTROLLER_NAME}GetProductPage`,
            type: "GET",
            data: {form},
        }).done(response => {
            console.log(response)
            dispatch({
                type: REFRESH_PRODUCT_PAGE,
                payload: {...response, productAmountOrderInput: 1, maxOrderSizeFlag: false}
            });
        });
    }
}








export function getAndRouteProductPage({productId, brHistory}) {
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}${PRODUCTS_CONTROLLER_NAME}GetProductPage`,
            type: "GET",
            data: {productId},
        }).done(response => {
            console.log(response)
            dispatch({
                type: REFRESH_PRODUCT_PAGE,
                payload: {...response, productAmountOrderInput: 1, maxOrderSizeFlag: false}
            });
        });
    }
}

export function uploadProducts(dispatch, add = false) {
    const state = store.getState();
    $.ajax({
        url: `${DOMAIN}${PRODUCTS_CONTROLLER_NAME}GetProducts`,
        type: "GET",
        data: {...state.catalogPage.filters, page: state.catalogPage.products.currentPage},
    }).done(response => {
        console.log(response)
        dispatch({
            type: add ? ADD_PRODUCTS : REFRESH_PRODUCTS,
            payload: response
        })
    });
}

export function uploadCategoriesAndBrands() {
    return async (dispatch) =>
        await $.ajax({
            url: `${DOMAIN}${PRODUCTS_CONTROLLER_NAME}GetCategoryAndBrands`,
            type: "GET",
        }).done(response => {
            dispatch({
                type: UPLOAD_CATEGORIES_AND_BRANDS,
                payload: response
            })
        });
}


export function setCurrentPage(currentPage) {
    return async dispatch => {
        dispatch({type: SET_CURRENT_PAGE, payload: currentPage});
        await uploadProducts(dispatch);
    }
}

export function addProducts(currentPage) {
    return async dispatch => {
        dispatch({type: SET_CURRENT_PAGE, payload: currentPage + 1});
        await uploadProducts(dispatch, true);
    }
}


export function setCategory1Filter(category1) {
    return async dispatch => {
        dispatch({type: SET_FILTER_CATEGORY1, payload: category1});
        await uploadProducts(dispatch);
    }
}

export function setCategory2Filter(category2) {
    return async dispatch => {
        dispatch({type: SET_FILTER_CATEGORY2, payload: category2});
        await uploadProducts(dispatch);
    }
}

export function setSort(sort) {
    return async dispatch => {
        dispatch({type: SET_FILTER_SORT, payload: sort});
        await uploadProducts(dispatch);
    }
}

export function setBrandFilter(brand) {
    return async dispatch => {
        dispatch({type: SET_FILTER_BRAND, payload: brand});
        await uploadProducts(dispatch);
    }
}

export function setMinPriceFilter(minPrice) {
    return async dispatch => {
        dispatch({type: SET_FILTER_MIN_PRICE, payload: minPrice});
        await uploadProducts(dispatch);
    }
}

export function setMaxPriceFilter(maxPrice) {
    return async dispatch => {
        dispatch({type: SET_FILTER_MAX_PRICE, payload: maxPrice});
        await uploadProducts(dispatch);
    }
}

export function increment() {
    return {
        type: INCREMENT_PP
    }
}

export function decrement() {
    return {
        type: DECREMENT_PP
    }
}

//
// export function setRegistrationName(input) {
//     console.log(input)
//     return {
//         type: SET_REGISTRATION_NAME_INPUT,
//         payload: input,
//     }
// }
// export function setRegistrationEmail(input) {
//     console.log(input)
//     return {
//         type: SET_REGISTRATION_EMAIL_INPUT,
//         payload: input,
//     }
// }
// export function setRegistrationPhone(input) {
//     console.log(input)
//     return {
//         type: SET_REGISTRATION_PHONE_INPUT,
//         payload: input,
//     }
// }
// export function setRegistrationPassword(input) {
//     console.log(input)
//     return {
//         type: SET_REGISTRATION_PASSWORD_INPUT,
//         payload: input,
//     }
// }
// export function setRegistrationPasswordConfirm(input) {
//     console.log(input)
//     return {
//         type: SET_REGISTRATION_PASSWORD_CONFIRMED_INPUT,
//         payload: input,
//     }
// }