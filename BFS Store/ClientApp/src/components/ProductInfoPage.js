import React from "react";
import {Route, Switch, useHistory, useLocation, useParams} from "react-router-dom";
import '../styles/ProductPage.css'
import {useDispatch, useSelector} from "react-redux";
import Header from "./Header";
import {decrement, getAndRouteProductPage, increment} from "../redux/ActionFactory";


export function ProductInfoPage({productInfoViewModel}) {
    const dispatcher = useDispatch();
    const brHistory = useHistory();
    let {productId} = useParams();
    // alert(productId+" == "+ productInfoViewModel.id)
    if (productInfoViewModel.id != productId) {
        dispatcher(getAndRouteProductPage({productId, brHistory}));
        console.log("YO")
    }
    let index = 0;
    // console.log(productInfoViewModel)
    return (
        <div>
            <Header/>
            <div className='pp-naw-block'></div>
            <div className="info-holder">
                <div className="pp-body-content">
                    <div className="pp-img-block">
                        <div className="pp-img">
                            <img src={productInfoViewModel.imgUrl} alt=""/>
                        </div>
                    </div>
                    <div className="pp-info-block">
                        <div>
                            <a href="">{productInfoViewModel.categoryFirstLvl.valueEn}</a>
                            <a href="">Lorem</a>
                        </div>
                        <h1>{productInfoViewModel.name}</h1>
                        <p>производитель: {productInfoViewModel.brand}</p>
                        <ul>
                            {productInfoViewModel.info.descriptionsLi.map(li => <li key={index++}>{li.value}</li>)}
                        </ul>

                        <p>
                            {productInfoViewModel.info.shortDescription.value}
                        </p>
                        <h2 className="pp-price-block">
                            {productInfoViewModel.priceUSD * 27}грн
                        </h2>
                        <div className="pp-available">
                            Доступность: <span style={{color: "#739c0b"}}>В наличии</span>
                        </div>

                        <div className="pp-add-count">
                            <div className="pp-add-count-holder">
                                <button disabled={productInfoViewModel.isDecrementButtonDisabled}
                                        onClick={() => dispatcher(decrement())}
                                        className="pp-increment-button">
                                    -
                                </button>
                                <input disabled={true} value={productInfoViewModel.productAmountOrderInput}
                                       className="pp-count-input"/>
                                <button disabled={productInfoViewModel.isIncrementButtonDisabled}
                                        onClick={() => dispatcher(increment())}
                                        className="pp-increment-button">
                                    +
                                </button>
                            </div>
                            <button type="submit" className="pp-add-cart-button">В корзину</button>
                        </div>

                        <div className="pp-line"/>

                        <p>Артикул: {productInfoViewModel.id}</p>
                        <p>Категория: {productInfoViewModel.categoryFirstLvl.valueEn}</p>

                    </div>
                    <div className="pp-delivery-block">
                        <h1>Доставка</h1>
                        <p className="pp-delivery-p">
                            — Доставка заказов осуществляется транспортной компанией «Нова пошта». Стоимость доставки
                            зависит от веса и количества товаров в заказе.
                            — Заказы на сумму более 1000 грн. доставляются бесплатно.
                        </p>
                        <h1>Оплата</h1>
                        <p className="pp-delivery-p">
                            — Онлайн-оплата кредитной или дебетовой картой при оформлении заказа на сайте.
                            — Оплата на расчетный счет в Приват банке.
                            — Оплата при получении (наложенный платеж). Комиссию «Новой почты» (20 грн. + 2% от суммы
                            перевода) оплачивает получатель.
                        </p>
                        <h1>Отправка</h1>
                        <p className="pp-delivery-p">
                            Отправка заказа день в день при условии оформления заказа:
                            Пн.-Сб.: до 13.00
                            Вс.: выходной
                        </p>
                    </div>
                </div>

                <div style={{display: "flex"}}>
                    <div style={{width: "1200px"}}>
                        {productInfoViewModel.info.dopDescriptions.map(
                            description => <div key={index++} dangerouslySetInnerHTML={{__html: description.value}}/>
                        )}
                    </div>
                    <div>
                        <h1>TABLE</h1>
                    </div>
                </div>
            </div>
        </div>
    );
}

//,position:"absolute"
// <table style="border: solid black 1px">
//     <tbody>
//     @foreach (var productIngredientsTableRow in productInfoViewModel.Info.Table)
//     {
//         <tr>
//             <td style="border: solid lightgrey 1px">@(new
//                 HtmlString(productIngredientsTableRow.FirstColumn))
//             </td>
//             <td style="border: solid lightgrey 1px">@(new
//                 HtmlString(productIngredientsTableRow.SecondColumn))
//             </td>
//             <td style="border: solid lightgrey 1px">@(new
//                 HtmlString(productIngredientsTableRow.ThirdColumn))
//             </td>
//         </tr>
//     }
//     </tbody>
// </table>