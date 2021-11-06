import {combineReducers} from "redux";
import {ProductPageViewModelReducer} from "./ProductPageViewModelReducer";
import {CatalogPageReducer} from "./CatalogPageReducer";
import {RegistrationReducer} from "../depricatedBackUp/RegistrationReducer";
import {reducer as formReducer} from "redux-form";

export const rootReducer = combineReducers(
    {
        productPageViewModel: ProductPageViewModelReducer,
        catalogPage: CatalogPageReducer,
        form: formReducer,
    }
);


