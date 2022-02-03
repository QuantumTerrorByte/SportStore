import React from "react";
import {useDispatch, useSelector} from "react-redux";
import s from "../../styles/CartMini.module.css";
import {getCartPrice} from "../../core/getCartPrice";
import {switchMiniCartFlagAction} from "../../redux/actions/UIActionFactory";
import {
    addToCardAction,
    decrementProductsInCartAction, removeFromCardAction
} from "../../redux/actions/CartActionFactory";
import {NavLink} from "react-router-dom";

const style = {
    fontSize: "19px"
};

export function CartMini({cart}) {
    const lastCartLine = cart[cart.length - 1];
    const dispatch = useDispatch();
    debugger
    return <div className={s.cartMini}>
        <div className={s.countHolder} style={{marginTop: "-15px"}}>
            <h1 className={s.countHolder__header}>
                Добавлен в корзину
                <br/>
                <span
                    style={{fontSize: "20px"}}>1 of {cart.length} items type</span>
            </h1>
            <div className={s.countHolder_exit}
                 onClick={(e) => dispatch(switchMiniCartFlagAction())}>
                x
            </div>
        </div>
        <div className={s.productsHolder}>
            {cart.map(cartLine => <div className={s.productHolder}
                                       key={cartLine.productId}>
                <img className={s.productHolder_img}
                     src={cartLine.productImg}
                     alt="XXX"
                     onClick={() => dispatch(removeFromCardAction(cartLine.productId))}/>
                <div className={s.productHolder_infoBlock}>
                    <div className={s.productHolder_info}>
                        {cartLine.productName}
                    </div>
                    <div className={s.productHolder_info}>
                    <span style={style} className={s.countInputBlock}>

                        <button className={s.countInputBlockCount_correctButton}
                                onClick={() => {
                                    if (cartLine.count > 1) {
                                        dispatch(decrementProductsInCartAction(cartLine.productId));
                                    }
                                }}>-</button>
                        <span className={s.countInputBlock_countInput}>
                            {cartLine.count}
                        </span>
                        <button className={s.countInputBlockCount_correctButton}
                                onClick={() => {
                                    dispatch(addToCardAction({
                                        productId: cartLine.productId,
                                        count: 1
                                    }))
                                }}>+</button>
                    </span>
                        <h6 style={style}>
                            {new Intl.NumberFormat('de-DE', {
                                style: 'currency',
                                currency: 'USD'
                            }).format(cartLine.productPrice)}
                        </h6>
                    </div>
                </div>
            </div>)}
        </div>
        <div className={s.approveHolder}>
            <div className={s.approveHolder_summaryTextPriceHolder}>
                <span className={s.cartPrice}>
                    Всего в корзине:
                </span>
                <h6 className={s.approveHolder_money}>
                    {new Intl.NumberFormat('de-DE', {
                        style: 'currency',
                        currency: 'USD'
                    }).format(getCartPrice(cart))}
                </h6>
            </div>
            {/*<button className={s.mainButton}>Оформить заказ</button>*/}
            <NavLink className={s.mainButton} to={{pathname: `/checkout/`}}>
                Оформить заказ
            </NavLink>
        </div>
    </div>
}

// <div className={s.productHolder}>
//     <img className={s.productHolder__img} src={lastCartLine.product.productImg}
//          alt="XXX"/>
//     <div className={s.productHolder__infoBlock}>
//         <div className={s.productHolder__info}>
//             {lastCartLine.product.productShortDescription}
//         </div>
//         <div className={s.productHolder__info}>
//             <span>Количество {lastCartLine.count}</span>
//             <h4>$ {lastCartLine.product.productPrice}</h4>
//         </div>
//     </div>
// </div>