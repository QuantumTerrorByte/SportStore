import React from "react";
import {render} from "react-dom";
import {useDispatch} from "react-redux";
import {EditProfileReduxForm} from "../forms/RegistrationAndEditProfileForm";
import {editUserData} from "../../redux/AuthActionsFactory";
import styles from '../../styles/SignUpSignInProfileEdit.module.css'


export const Profile = () => {
    console.log()
    const dispatch = useDispatch();
    return (
        <div className={styles.editProfileContentBlock}>
            <EditProfileReduxForm styles={styles} onSubmit={(form) => dispatch(editUserData(form))}/>
        </div>
    );
}