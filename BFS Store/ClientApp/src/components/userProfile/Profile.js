import React from "react";
import {useDispatch, useSelector} from "react-redux";
import {EditProfileReduxForm} from "../forms/RegistrationAndEditProfileForm";
import {editUserData} from "../../redux/actions/AuthActionsFactory";
import styles from '../../styles/SignUpSignInProfileEdit.module.css'


export const Profile = () => {
    const id = useSelector(s=> s.userData.userId);
    console.log(id);
    const dispatch = useDispatch();
    return (
        <div className={styles.editProfileContentBlock}>
            <EditProfileReduxForm styles={styles} onSubmit={(form) => dispatch(editUserData({id,...form}))}/>
        </div>
    );
}