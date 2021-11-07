import React from 'react';
import Products from "./Products";
import Header from "./Header";
import LeftFiltersBar from "./LeftFiltersBar";
import '../styles/ProductBlockForCostumers.css'
import {useDispatch, useSelector} from "react-redux";
import {setBrandFilter, setCategory1Filter, setSort} from "../redux/ProductsActionsFactory";
import {FiltersRemover} from "./FiltersRemover";


export function Home(catalogPage) {
    // debugger
    const dispatch = useDispatch();
    return (
        <div className="content-block">
            <div className="body-content">
                <div className="borderedDev">
                    <LeftFiltersBar leftBarViewModel={{
                        categories: {
                            actionCreator: setCategory1Filter,
                            itemList: catalogPage.categories1,
                            tittle: "Categories"
                        },
                        brands: {
                            actionCreator: setBrandFilter,
                            itemList: catalogPage.brands,
                            tittle: "Brands"
                        }
                    }}/>
                </div>
                <div className="contentBlock">
                    <div className="borderedDev">
                        <select name="sort" id="sort"
                                onChange={(e) => dispatch(setSort(e.target.value))}>
                            <option value="descendingPrice">Descending Price</option>
                            <option value="increasingPrice">Increasing Price</option>
                        </select>
                        <a href='/Info/'>Info</a>
                    </div>
                    <div className="borderedDev">
                        <FiltersRemover className="filter-remover" filters={catalogPage.filters}/>
                    </div>
                    <div className="borderedDev">
                        <Products products={catalogPage.products} filters={catalogPage.filters}/>
                    </div>
                </div>
            </div>
        </div>
    )
}







