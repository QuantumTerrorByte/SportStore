import React from "react";
import styles from '../styles/SignUpSignInProfileEdit.module.css'



export const FormInput = ({input, meta, ...props}) => {
    const hasError = meta.touched && meta.error;
    debugger
    return (
        <div className={styles.inputBlock}>
            {hasError ? <span className={styles.inputBlockErrorText}>{meta.error}</span> : ""}
            <label> {input.name}
                <input {...input} {...props} className={hasError ? styles.inputBlockErrorInput : ""}/>
            </label>
        </div>
    )
}

// regMain
// regBlankHolder
// regInput
// regLabel
// regSubmitButton
//{hasError ? "input-block-error-input" : ""}