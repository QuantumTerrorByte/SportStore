import React from "react";
import {
    ADD_PRODUCTS, DECREMENT, DOMAIN, INCREMENT, REFRESH_PRODUCT_PAGE,
    REFRESH_PRODUCTS,
    SET_CURRENT_PAGE, SET_FILTER_BRAND,
    SET_FILTER_CATEGORY1,
    SET_FILTER_CATEGORY2, SET_FILTER_MAX_PRICE, SET_FILTER_MIN_PRICE, SET_FILTER_SORT, UPLOAD_CATEGORIES_AND_BRANDS,
} from "./ActionsEnum";
import $ from "jquery";
import {store} from "../index";

export function getAndRouteProductPage({productId, brHistory}) {
    return async dispatch => {
        $.ajax({
            url: `${DOMAIN}Test/GetProductPage`,
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
        url: `${DOMAIN}Test/GetProducts`,
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
            url: `${DOMAIN}Test/GetCategoryAndBrands`,
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
        type: INCREMENT
    }
}

export function decrement() {
    return {
        type: DECREMENT
    }
}

