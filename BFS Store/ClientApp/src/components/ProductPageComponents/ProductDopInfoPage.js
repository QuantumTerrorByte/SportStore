import React from "react";
import '../../styles/ProductPage.css'


export function ProductDopInfoPage(productInfoViewModel) {
    const src = productInfoViewModel.info.table;

    return (<table>
            <tbody> {src.map(e => {
                return <tr>
                    <th dangerouslySetInnerHTML={{__html: e.firstColumn}}/>
                    <th dangerouslySetInnerHTML={{__html: e.secondColumn}}/>
                    <th dangerouslySetInnerHTML={{__html: e.thirdColumn}}/>
                </tr>
            })}
            </tbody>
        </table>
    )
}
