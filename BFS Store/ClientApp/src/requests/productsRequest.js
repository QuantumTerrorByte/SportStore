import $ from 'jquery'
export function productsRequest() {
    $.ajax({
        url: "https://localhost:5005/Test/Get",
        type: "GET",
        types: "json",
        dataType: "json",
        accept: "json",
        data: {
            MaxPrice: 10,
            minPrice: 15,
        }
    }).done(response => {console.log(response)});
}