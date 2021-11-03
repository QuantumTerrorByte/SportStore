import {combineReducers} from "redux";
import {ProductPageViewModelReducer} from "./ProductPageViewModelReducer";
import {CatalogPageReducer} from "./CatalogPageReducer";

export const rootReducer = combineReducers(
    {
        productPageViewModel: ProductPageViewModelReducer,
        catalogPage: CatalogPageReducer
    }
);


