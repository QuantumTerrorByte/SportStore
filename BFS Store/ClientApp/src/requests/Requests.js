import $ from "jquery";

export const AuthorisedRequest = (path,type, data, done, fail) => {
    $.ajax(path, {
        type: type,
        dataType: "json",
        contentType: "application/json",
        data: data,
        beforeSend: function(request) {
            request.setRequestHeader("Authorization", localStorage.getItem("JWT"));
        },
    }).done(done).fail(fail);
}