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


const lengthValidation = lengthValidatorCreator(5, 25);


function RegistrationAndEditProfileForm({styles, ...props}) { //todo confirm pass verification and combine with editProfile form
    return (
        <form className={styles.regBlock}>
            <Field validate={[lengthValidation, requireValidation]} component={FormInput}
                   name={'userName'} placeholder={'Name'} styles={styles}/>

            <Field validate={[lengthValidation, phoneValidator]} component={FormInput}
                   name={'phoneNumber'} placeholder={'Phone'} styles={styles}/>

            <Field validate={[lengthValidation, emailValidation]} component={FormInput}
                   name={'email'} placeholder={'Email'} styles={styles}/>

            <Field validate={[lengthValidation, passwordValidation]} component={FormInput}
                   name={'password'} placeholder={'Password'} styles={styles}/>

            <Field validate={[lengthValidation, passwordValidation]} component={FormInput}
                   name={'confirmPassword'} placeholder={'Password'} styles={styles}/>

            <button type='submit' className={styles.formButton}>Login</button>
        </form>
    )
}

export const RegistrationReduxForm = reduxForm({
    form: 'registrationForm',
})(RegistrationAndEditProfileForm)
export const EditProfileReduxForm = reduxForm({
    form: 'EditProfileForm',
})(RegistrationAndEditProfileForm)