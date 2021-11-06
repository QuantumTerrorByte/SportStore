import React from "react";
import {Field, reduxForm} from "redux-form";
import {FormInput} from "../FormInput";
import {
    emailValidation,
    lengthValidatorCreator,
    passwordValidation,
    phoneValidator,
    requireValidation
} from "../Validations";

import styles from '../../styles/SignUpSignInProfileEdit.module.css'

export const lengthValidation = lengthValidatorCreator(5, 20);


function RegistrationAndEditProfileForm(props) {
    return (
        <form onSubmit={props.handleSubmit} className={styles.regBlock}>
            <Field validate={[lengthValidation, requireValidation]}
                   name={'userName'} placeholder={'Name'} component={FormInput}/>

            <Field validate={[lengthValidation, phoneValidator]}
                   name={'phoneNumber'} placeholder={'Phone'} component={FormInput}/>

            <Field validate={[lengthValidation, emailValidation]}
                   name={'email'} placeholder={'Email'} component={FormInput}/>

            <Field validate={[lengthValidation, passwordValidation]}
                   name={'password'} placeholder={'Password'} component={FormInput}/>

            <Field validate={[lengthValidation, passwordValidation]}
                   name={'confirmPassword'} placeholder={'Confirm password'} component={FormInput}/>
            <button type={'submit'} className={styles.formButton}>Login</button>
        </form>
    )
}

export const RegistrationAndEditProfileReduxForm = reduxForm({
    form: 'registrationAndEditProfile',
})(RegistrationAndEditProfileForm)