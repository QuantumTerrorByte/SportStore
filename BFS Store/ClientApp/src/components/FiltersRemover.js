import React from "react";
import {useDispatch} from "react-redux";
import {
    setBrandFilter,
    setCategory1Filter,
    setCategory2Filter,
    setMaxPriceFilter,
    setMinPriceFilter
} from "../redux/actions/ProductsActionsFactory";
import styles from '../styles/ProductsFilters.module.css'

export function FiltersRemover({filters}) {
    const dispatch = useDispatch();
    const result = [];

    for (const filter in filters) {
        if (filters[filter] !== "") {
            switch (filter) {
                case 'category1':
                    result.push(<span
                        onClick={e => dispatch(setCategory1Filter(""))}
                        className={styles.filterRemoverItem}
                        key={filter}>
                        Category:{filters[filter]}
                    </span>);
                    break;
                case 'category2':
                    result.push(<span
                        onClick={e => dispatch(setCategory2Filter(""))}
                        className={styles.filterRemoverItem}
                        key={filter}>
                        Category:{filters[filter]}
                    </span>);
                    break;
                case 'brand':
                    result.push(<span
                        onClick={e => dispatch(setBrandFilter(""))}
                        className={styles.filterRemoverItem}
                        key={filter}>
                        Brand:{filters[filter]}
                    </span>);
                    break;
                case 'minPrice':
                    result.push(<span
                        onClick={e => dispatch(setMinPriceFilter(""))}
                        className={styles.filterRemoverItem}
                        key={filter}>
                        Min price:{filters[filter]}
                    </span>);
                    break;
                case 'maxPrice':
                    result.push(<span
                        onClick={e => dispatch(setMaxPriceFilter(""))}
                        className={styles.filterRemoverItem}
                        key={filter}>
                        Max price:{filters[filter]}
                    </span>);
                    break;
                default:
                    break;
            }
        }
    }
    return <div className={styles.filterRemoversBlock}>{result}</div>;
}