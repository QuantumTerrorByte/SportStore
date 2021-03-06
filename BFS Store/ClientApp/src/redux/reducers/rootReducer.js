import {combineReducers} from "redux";
import {ProductPageViewModelReducer} from "./ProductPageViewModelReducer";
import {CatalogPageReducer} from "./CatalogPageReducer";
import {reducer as formReducer} from "redux-form";
import {UserDataReducer} from "./UserDataReducer";
import {UIReducer} from "./UIReducer";
import {CartReducer} from "./CartReducer";

export const rootReducer = combineReducers(
    {
        productPageViewModel: ProductPageViewModelReducer,
        catalogPage: CatalogPageReducer,
        userData: UserDataReducer,
        uiFlags: UIReducer,
        form: formReducer,
        cart: CartReducer,
    }
);


