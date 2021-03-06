import React from "react";
import {initialState} from "../InitialState";
import {DECREMENT_PP, INCREMENT_PP, REFRESH_PRODUCT_PAGE} from "../Consts";

export function ProductPageViewModelReducer(state = initialState.productPageViewModel, action) {
    switch (action.type) {
        case REFRESH_PRODUCT_PAGE:
            return {...state, ...action.payload};
        case INCREMENT_PP:
            return state.amount > state.productAmountOrderInput ?
                {
                    ...state,
                    productAmountOrderInput: (state.productAmountOrderInput + 1),
                    isDecrementButtonDisabled: false
                } :
                {...state, isIncrementButtonDisabled: true};
        case DECREMENT_PP:
            return state.productAmountOrderInput > 1 ?
                {
                    ...state,
                    productAmountOrderInput: (state.productAmountOrderInput - 1),
                    isIncrementButtonDisabled: false
                } :
                {...state, isDecrementButtonDisabled: true};
        default:
            return state;
    }
}