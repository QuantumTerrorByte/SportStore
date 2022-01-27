import React from "react";
import '../styles/PageButtons.css'
import {useDispatch} from "react-redux";
import {setCurrentPage} from "../redux/actions/ProductsActionsFactory";

export default function Pagination({paging, currentPage}) {
    const dispatcher = useDispatch();
    return (
        <div className={"pageButtonsBlock"}>
            {paging.map(pageNumber =>
                pageNumber === currentPage ?
                    <div key={pageNumber} className={"pageButtonCurrent"}>
                        {pageNumber}
                    </div> :
                    <div onClick={() => dispatcher(setCurrentPage(pageNumber))}
                         key={pageNumber} className={"pageButtonCommon"}>
                        {pageNumber}
                    </div>
            )
            }
        </div>);
}