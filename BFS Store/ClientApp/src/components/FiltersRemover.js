import React from "react";
import {useDispatch} from "react-redux";
import {
    setBrandFilter,
    setCategory1Filter,
    setCategory2Filter,
    setMaxPriceFilter,
    setMinPriceFilter
} from "../redux/ProductsActionsFactory";

export function FiltersRemover({filters}) {
    const dispatch = useDispatch();
    const result = [];

    for (const filter in filters) {
        if (filters[filter] !== "") {
            switch (filter) {
                case 'category1':
                    result.push(<span
                        onClick={e => dispatch(setCategory1Filter(""))}
                        className="filter-remover-item"
                        key={filter}>
                        Category:{filters[filter]}
                    </span>);
                    break;
                case 'category2':
                    result.push(<span
                        onClick={e => dispatch(setCategory2Filter(""))}
                        className="filter-remover-item"
                        key={filter}>
                        Category:{filters[filter]}
                    </span>);
                    break;
                case 'brand':
                    result.push(<span
                        onClick={e => dispatch(setBrandFilter(""))}
                        className="filter-remover-item"
                        key={filter}>
                        Brand:{filters[filter]}
                    </span>);
                    break;
                case 'minPrice':
                    result.push(<span
                        onClick={e => dispatch(setMinPriceFilter(""))}
                        className="filter-remover-item"
                        key={filter}>
                        Min price:{filters[filter]}
                    </span>);
                    break;
                case 'maxPrice':
                    result.push(<span
                        onClick={e => dispatch(setMaxPriceFilter(""))}
                        className="filter-remover-item"
                        key={filter}>
                        Max price:{filters[filter]}
                    </span>);
                    break;
                default:
                    break;
            }
        }
    }
    return result;
}