let productsArea = document.querySelector("#products-output-area");

let brandSelector = document.querySelector("#brand-selector");
let categorySelector = document.querySelector("#category-selector");
let minPriceInput = document.querySelector('#min-price');
let maxPriceInput = document.querySelector('#max-price');
let priceFilterButton = document.querySelector("#price-filter-button");
let minPriceBuffer = {value: 0};
let maxPriceBuffer = {value: 5000};

function refreshBuffer() {
    minPriceBuffer.value = minPriceInput.value;
    maxPriceBuffer.value = maxPriceInput.value;
}

priceFilterButton.addEventListener('click', (e) => {
    refreshBuffer();
});

let filtersRequestDataSrc = {
    minPrice: minPriceBuffer,
    maxPrice: maxPriceBuffer,
    brand: brandSelector,
    category: categorySelector,
}

function createFiltersRequestData(requestDataSrc, page = 1) {
    return {
        minPrice: requestDataSrc.minPrice.value,
        maxPrice: requestDataSrc.maxPrice.value,
        brand: requestDataSrc.brand.value,
        category: requestDataSrc.category.value,
        page: page,
    }
}



function refresh(minPriceInput, maxPriceInput) {
    $.ajax({
        type: "GET",
        url: "https://localhost:5005/Product/Products",
        data: {
            minPrice: minPriceInput.value,
            maxPrice: maxPriceInput.value,
        }
    }).done(response => {
        console.log(response);
        productsArea.innerHTML = response;
    });
}
refresh(minPriceInput,maxPriceInput);






