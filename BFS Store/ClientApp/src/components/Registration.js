import React from "react";
import {useDispatch} from "react-redux";
import {RegistrationAndEditProfileReduxForm} from "./forms/RegistrationAndEditProfileForm";

export const SignIn = () => {
    const dispatch = useDispatch();
    return (
        <div>
            <RegistrationAndEditProfileReduxForm onSubmit={console.log}/>
        </div>
    )
}

// <div className="reg-blank-holder">
//     <label className='reg-label'> Name
//         <input onChange={(e)=>dispatch(setRegistrationName(e.target.value))}
//                className='reg-input' type="text" value={registrationPage.nameInput} placeholder="Name"/>
//     </label>
//     <label onChange={(e)=>dispatch(setRegistrationEmail(e.target.value))}
//            className='reg-label'> Email
//         <input className='reg-input' type="text" value={registrationPage.emailInput} placeholder="Email"/>
//     </label>
//     <label onChange={(e)=>dispatch(setRegistrationPhone(e.target.value))}
//            className='reg-label'> Phone
//         <input className='reg-input' type="text" value={registrationPage.phoneInput}  placeholder="Phone"/>
//     </label>
//     <label onChange={(e)=>dispatch(setRegistrationPassword(e.target.value))}
//            className='reg-label'> Password
//         <input className='reg-input' type="text" value={registrationPage.passwordInput} placeholder="Password"/>
//     </label>
//     <label onChange={(e)=>dispatch(setRegistrationPasswordConfirm(e.target.value))}
//            className='reg-label'> Confirm password
//         <input className='reg-input' type="text" value={registrationPage.passwordConfirmInput} placeholder="Confirm password"/>
//     </label>
//
//     <button className='reg-submit-button'>Submit</button>
// </div>