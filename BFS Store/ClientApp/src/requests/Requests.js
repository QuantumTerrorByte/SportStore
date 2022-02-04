import $ from "jquery";
import {log} from "../core/log";

export const requestDecorator = (path, type, data, withAuth = false, done = null, fail = null) => {
    $.ajax(path, {
        type: type,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(data),
        beforeSend:
            withAuth && localStorage.getAuthStatus() ?
                request => request.setRequestHeader("Authorization", localStorage.getItem("JWT")) :
                null,
    }).done(response => {
        if (done == null) {
            log("response took", response)
        }
        else {
            done(response)
        }
    }).fail(error => {
        if (fail == null) {
            log("", error)
        }
        else fail(error);
    });
}