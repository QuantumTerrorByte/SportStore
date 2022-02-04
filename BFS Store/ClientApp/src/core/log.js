import {LOGS_STORE} from "../redux/Consts";

//alpha encapsulate logs, for easy rework in one place in future
// eslint-disable-next-line no-undef
export function log(description, value = null, dateTime = null) {
    const log = {
        description,
        dateTime: dateTime ?? new Date().timeNow(),
        error: value,
    }
    console.log(log);
    logDecoratorLS(log);
}

//temporal logger
function logDecoratorLS(log) { //todo send logs on server by timeout
    if (log !== null) {
        localStorage.addValue(LOGS_STORE, log);
    }
}