import React from "react";
import {initialState} from "../InitialState";
import {
    ADD_PRODUCTS,
    REFRESH_PRODUCTS,
    SET_CURRENT_PAGE,
    SET_FILTER_BRAND,
    SET_FILTER_CATEGORY1,
    SET_FILTER_CATEGORY2,
    SET_FILTER_MAX_PRICE, SET_FILTER_MIN_PRICE,
    SET_FILTER_SORT, UPLOAD_CATEGORIES_AND_BRANDS
} from "../Consts";

export function CatalogPageReducer(state = initialState.catalogPage, action) {
    // console.log(action)
    switch (action.type) {
        case SET_FILTER_CATEGORY1:
            return {
                ...state,
                products: {...state.products, currentPage: 1},
                filters: {...state.filters, category1: action.payload}
            };
        case SET_FILTER_CATEGORY2:
            return {
                ...state,
                products: {...state.products, currentPage: 1},
                filters: {...state.filters, category2: action.payload}
            };
        case SET_FILTER_BRAND:
            return {
                ...state,
                products: {...state.products, currentPage: 1},
                filters: {...state.filters, brand: action.payload}
            };
        case SET_FILTER_SORT:
            return {
                ...state,
                filters: {...state.filters, sort: action.payload}
            };
        case SET_FILTER_MAX_PRICE:
            return {
                ...state,
                products: {...state.products, currentPage: 1},
                filters: {...state.filters, maxPrice: action.payload}
            };
        case SET_FILTER_MIN_PRICE:
            return {
                ...state,
                products: {...state.products, currentPage: 1},
                filters: {...state.filters, minPrice: action.payload}
            };
        case SET_CURRENT_PAGE:
            return {
                ...state,
                products: {...state.products, currentPage: action.payload}
            };
        case REFRESH_PRODUCTS:
            return {
                ...state, products: {
                    productsList: action.payload.productsList,
                    pagination: action.payload.pagination,
                    currentPage: state.products.currentPage,
                }
            };

        case ADD_PRODUCTS:
            return {
                ...state, products: {
                    productsList: state.products.productsList.concat(action.payload.productsList),
                    pagination: action.payload.pagination,
                    currentPage: state.products.currentPage,
                }
            };
        case UPLOAD_CATEGORIES_AND_BRANDS:
            return {
                ...state, ...action.payload
            };
        default:
            return state;
    }
}