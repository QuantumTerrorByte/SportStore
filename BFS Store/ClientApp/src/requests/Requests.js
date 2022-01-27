import $ from "jquery";
import {log} from "../core/log";

export const AuthorisedRequest = (path, type, data, done = log, fail = log) => {
    $.ajax(path, {
        type: type,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(data),
        beforeSend: function (request) {
            request.setRequestHeader("Authorization", localStorage.getItem("JWT"));
        },
    }).done(response => {
        done(response);
    }).fail(error => {
        fail("", new Date().timeNow(), error);
    });
}