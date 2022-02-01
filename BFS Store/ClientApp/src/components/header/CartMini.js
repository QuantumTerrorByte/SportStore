import React from "react";
import {useDispatch, useSelector} from "react-redux";
import s from "../../styles/CartMini.module.css";
import {getCartPrice} from "../../core/getCartPrice";
import {switchMiniCartFlagAction} from "../../redux/actions/UIActionFactory";

const style = {
    fontSize: "19px"
};

export function CartMini({cart}) {
    const lastCartLine = cart[cart.length - 1];
    const dispatch  = useDispatch();
    debugger
    return <div className={s.cartMini}>
        <div className={s.countHolder}>
            <h3 className={s.countHolder__header}>
                Добавлен в корзину:
            </h3>
            <span style={{marginLeft: "10px"}}>
                1 of {cart.length} items
            </span>
            <div className={s.countHolder__exit}
                  onClick={(e) => dispatch(switchMiniCartFlagAction())}>
                x
            </div>
        </div>
        <div className={s.productsHolder}>
            {cart.map(lastCartLine => <div className={s.productHolder}>
                <img className={s.productHolder__img}
                     src={lastCartLine.product.productImg}
                     alt="XXX"/>
                <div className={s.productHolder__infoBlock}>
                    <div className={s.productHolder__info}>
                        {lastCartLine.product.productShortDescription}
                    </div>
                    <div className={s.productHolder__info}>
                    <span style={style}>
                        Количество {lastCartLine.count}
                    </span>
                        <h5 style={style}>
                            $ {lastCartLine.product.productPrice}
                        </h5>
                    </div>
                </div>
            </div>)}
        </div>
        <div className={s.approveHolder}>
            <div className={s.approveHolder__summaryTextPriceHolder}>
                <span style={style}>
                    Всего в корзине:
                </span>
                <h5 className={s.approveHolder__money}>
                    $ {getCartPrice(cart)}
                </h5>
            </div>
            <button className={s.mainButton}>Оформить заказ</button>
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