import React from "react";
import {Field, reduxForm} from "redux-form";
import {
    emailValidation,
    lengthValidatorCreator,
    passwordValidation, phoneValidator, requireValidation
} from "../Validations";
import {FormInput, FormInputTest} from "../FormInput";
import styles from '../../styles/SignUpSignInProfileEdit.module.css';

const lengthValidation = lengthValidatorCreator(1, 25);
// OrderViewModel {
//     string Email { get; set; }
//     string Phone { get; set; }
//     string FirstName { get; set; }
//     string SecondName { get; set; }
//     string Patronymic { get; set; }
//     string Comment { get; set; }
//     bool GiftWrap { get; set; } //todo remove
//
//     Address Address { get; set; }
//
//     List<ProductLineViewModel> CartLines { get; set; }
// }

// Address {
//      long Id { get; set; }
//      string PostalOffice { get; set; }
//      string City { get; set; }
//      string House { get; set; }
//      string Street { get; set; }
//      string Apartment { get; set; }
// }
// ProductLineViewModel{
//      productId,
//      quantity
//}
function CheckoutForm(props) {

    return <form style={{display:"flex"}} onSubmit={props.handleSubmit}>
        <div className={styles.regBlock}>
            <Field validate={[lengthValidation, emailValidation]}
                   component={FormInput} name={'email'}
                   placeholder={'email'} styles={styles}/>
            <Field validate={[lengthValidation, phoneValidator]}
                   component={FormInput} name={'phoneNumber'}
                   placeholder={'phoneNumber'} styles={styles}/>
            <Field validate={[lengthValidation]}
                   component={FormInput} name={'firstName'}
                   placeholder={'firstName'} styles={styles}/>
            <Field validate={[lengthValidation]}
                   component={FormInput} name={'secondName'}
                   placeholder={'secondName'} styles={styles}/>
            <Field validate={[lengthValidation]}
                   component={FormInput} name={'patronymic'}
                   placeholder={'patronymic'} styles={styles}/>
            <Field validate={[lengthValidation]}
                   component={FormInput} name={'comment'}
                   placeholder={'comment'} styles={styles}/>

            <button type='submit' className={styles.formButton}>Login</button>
        </div>
        <div className={styles.regBlock}>
            <AddressReduxForm/>
        </div>
    </form>
}

function AddressForm(props) {
    return <div className={styles.regBlock}>
        <Field validate={[lengthValidation]}
               component={FormInput} name={'postalOffice'}
               placeholder={'postalOffice'} styles={styles}/>
        <Field validate={[lengthValidation]}
               component={FormInput} name={'city'}
               placeholder={'city'} styles={styles}/>
        <Field validate={[lengthValidation]}
               component={FormInput} name={'house'}
               placeholder={'house'} styles={styles}/>
        <Field validate={[lengthValidation]}
               component={FormInput} name={'street'}
               placeholder={'street'} styles={styles}/>
        <Field validate={[lengthValidation]}
               component={FormInput} name={'apartment'}
               placeholder={'apartment'} styles={styles}/>
    </div>
}

export const CheckoutReduxForm = reduxForm({
    form: "checkoutForm"
})(CheckoutForm);
export const AddressReduxForm = reduxForm({
    form: "checkoutForm"
})(AddressForm);

