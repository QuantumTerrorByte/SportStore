import $ from "jquery";

export const AuthorisedRequest = async (path,type, data, done, fail) => {
    $.ajax(path, {
        type: type,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(data),
        beforeSend: function(request) {
            request.setRequestHeader("Authorization", localStorage.getItem("JWT"));
        },
    }).done(done).fail(fail);
}