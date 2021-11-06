import React from "react";
import {Field, reduxForm} from "redux-form";
import {FormInput} from "../FormInput";
import {
    emailValidation,
    lengthValidatorCreator,
    passwordValidation,
} from "../Validations";
import styles from '../../styles/SignUpSignInProfileEdit.module.css'

const lengthValidation = lengthValidatorCreator(5,20);



function LoginForm(props) {
    return (
        <form onSubmit={props.handleSubmit} className={styles.loginForm}>

            <Field validate={[lengthValidation, emailValidation]} name={'email'}
                   placeholder={'email'} component={FormInput}/>

            <Field validate={[lengthValidation, passwordValidation]} name={'password'}
                   placeholder={'password'} component={FormInput}/>

            <button type={'submit'} className={styles.formButton}>Login</button>

        </form>
    )
}

export const LoginReduxForm = reduxForm({
    form: 'login',
})(LoginForm)