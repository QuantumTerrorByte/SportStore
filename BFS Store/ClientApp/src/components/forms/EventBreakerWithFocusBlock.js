import React from "react";
import {SWITCH_AUTH_FORM_BACKGROUND_FLAG} from "../../redux/Consts";
import {useDispatch} from "react-redux";
import styles from '../../styles/Home.module.css'


export const EventBreakerWithFocusBlock = ({signInUpHolder, ...props}) => {
    const dispatch = useDispatch();
    const className = signInUpHolder ? styles.authFormHolder : styles.none;
    const formHolder = () => dispatch({type: SWITCH_AUTH_FORM_BACKGROUND_FLAG});
    return (
        <div onClick={formHolder} className={className}>
            <div onClick={(e) => e.stopPropagation()}>

            </div>
        </div>
    )
}