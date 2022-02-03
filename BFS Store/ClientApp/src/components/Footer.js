import React from "react";
import '../styles/Header.css'
import {useHistory} from "react-router-dom";
import {useDispatch} from "react-redux";
import styles from "../styles/ProductsFilters.module.css";


export default function Footer({styles}) {
    const browserHistory = useHistory();
    const dispatch = useDispatch();
    return (
        <div className={styles.futterBlock}>
            <div className={styles.footerLoginBlockHolder}>
                <button className={styles.footerButton}>Sign in</button>
            </div>
            <div className={styles.footerLine}>
                <h1>Back to top</h1>
            </div>
            <div className={styles.footerContent}>
                <table className={styles.footerTable}>
                    <thead>
                    <tr>
                        <th>Info about company</th>
                        <th>Help</th>
                        <th>Services</th>
                        <th>For partners</th>
                    </tr>
                    </thead>
                    <tbody>
                    <tr>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                    </tr>
                    <tr>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                    </tr>
                    <tr>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                    </tr>
                    <tr>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                    </tr>
                    <tr>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                        <th>lorem</th>
                    </tr>
                    </tbody>
                </table>
            </div>
            <div className={styles.footerPS}>
                <div className={styles.footerLogo}></div>
                <button>English</button>
                <button>Usd</button>
                <button>Ukraine</button>
            </div>
        </div>
    )
}