import React from "react";
import {Field, reduxForm} from "redux-form";
import {FormInput} from "../FormInput";
import {
    emailValidation,
    lengthValidatorCreator,
    passwordValidation,
} from "../Validations";
import s from '../../styles/SignUpSignInProfileEdit.module.css'
import {NavLink} from "react-router-dom";

const lengthValidation = lengthValidatorCreator(5, 25);
//styles for FormInput
// inputBlock
// inputBlockErrorText
// inputBlockErrorInput
// loginForm
function LoginForm({styles, ...props}) {
    // debugger
    return (
        <form onSubmit={props.handleSubmit} className={styles.loginForm}>

            <Field validate={[lengthValidation, emailValidation]} component={FormInput}
                   name={'email'} placeholder={'email'} styles={styles}/>
            <Field validate={[lengthValidation, passwordValidation]} component={FormInput}
                   name={'password'} placeholder={'password'} styles={styles}/>
            <button type='submit' className={styles.formButton}>Login</button>
            <NavLink to='/SignUp'>SignUp</NavLink>
        </form>
    )
}

export const LoginReduxForm = reduxForm({
    form: 'signIn',
})(LoginForm)

