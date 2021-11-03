document.querySelector('#redirect-button').addEventListener('click', isExist, true);



function isExist() {
    $.ajax('https://localhost:5001/AdminProductInfo/IsExistInfo?productId=10&lang=1', {
        type: "GET",
        dataType: "Json",
        crossDomain: true,
    })
        .done(response => {
            if (response['isExist'] === "true") {
                document.location.href = response['url'];
            } else {
                alert("Not exist");
            }
        })
        .fail(function (xhr, textStatus, errorThrown) {
            alert(xhr.responseText);
            alert(textStatus);
        });
}