import React from 'react';
import Products from "./Products";
import LeftFiltersBar from "./LeftFiltersBar";
import '../styles/ProductBlockForCostumers.css'
import {useDispatch} from "react-redux";
import {setBrandFilter, setCategory1Filter, setSort} from "../redux/ProductsActionsFactory";
import {FiltersRemover} from "./FiltersRemover";
import styles from '../styles/ProductsFilters.module.css'

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
                    <div className={styles.filtersCancelsAndSortBlock}>
                        <FiltersRemover filters={catalogPage.filters}/>
                        <select onChange={(e) => dispatch(setSort(e.target.value))}
                                className={styles.priseSorter}>
                            <option value="descendingPrice">Descending Price</option>
                            <option value="increasingPrice">Increasing Price</option>
                        </select>
                    </div>
                    <div className="borderedDev">
                        <Products products={catalogPage.products} filters={catalogPage.filters}/>
                    </div>
                </div>
            </div>
        </div>
    )
}







