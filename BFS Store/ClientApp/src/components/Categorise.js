import React from "react";
import {useDispatch} from "react-redux";
import styles from '../styles/ProductsFilters.module.css';

export function Categorise({itemList, actionCreator, tittle,}) {
    const dispatch = useDispatch();
    let index = 0;
    return (
        <ul className={styles.leftBarButtonsHolder}>
            <li className={styles.leftBarCurrentButton}>{tittle}</li>
            {
                itemList.map(item =>
                    <li key={item} className={styles.leftBarButton} onClick={() => dispatch(actionCreator(item))}>
                        {item}
                    </li>)
            }
        </ul>
    );
}