import React from "react";


export const FormInput = ({input, meta, styles, ...props}) => {
    const hasError = meta.touched && meta.error;
    let style = styles.headerLoginInput;
    style += hasError ? " " + styles.inputBlockErrorInput : "";

    debugger
    return (
        <label
            className={styles.inputBlockLabel}>
            {hasError ? <span
                className={styles.inputBlockErrorText}>{meta.error}</span> : ""}
            <input type='text' {...input} {...props} className={style}/>
        </label>
    )
}


// <div className={styles.inputBlock}>
// regMain
// regBlankHolder
// regInput
// regLabel
// regSubmitButton
//{hasError ? "input-block-error-input" : ""}