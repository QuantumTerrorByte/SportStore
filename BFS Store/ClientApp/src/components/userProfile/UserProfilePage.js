import React from "react";
import {NavLink, Route, Switch} from "react-router-dom";
import {Orders} from "./Orders";
import {ViewedProducts} from "./ViewedProducts";
import {Comments} from "./Comments";
import {Likes} from "./Likes";
import {Profile} from "./Profile";
import styles from "../../styles/UserProfile.module.css"

export const UserProfilePage = (userData) => {

    return (
        <div className={styles.userProfileMain}>
            <div className={styles.profileLeftNavBar}>
                <NavLink to='/'>Profile</NavLink>
                <NavLink to='/UserProfilePage/Orders'>Orders</NavLink>
                <NavLink to='/UserProfilePage/Likes'>Likes</NavLink>
                <NavLink to='/UserProfilePage/ViewedProducts'>ViewedProducts</NavLink>
                <NavLink to='/UserProfilePage/Comments'>Comments</NavLink>
            </div>
            <div className={styles.profileContentBlock}>
                <div className={styles.profileLocalHeader}>Личные данные</div>
                <Switch>
                    <Route path="/UserProfilePage/Orders">
                        <Orders/>
                    </Route>
                    <Route path='/UserProfilePage/Likes'>
                        <Likes/>
                    </Route>
                    <Route path='/UserProfilePage/ViewedProducts'>
                        <ViewedProducts/>
                    </Route>
                    <Route path='/UserProfilePage/Comments'>
                        <Comments/>
                    </Route>
                    <Route path='/'>
                        <Profile/>
                    </Route>
                </Switch>
            </div>
        </div>
    );
}