export var lSDecorator = function getLSDecorator() {
    const get = localStorage.getItem;
    const set = localStorage.setItem;


    return {
        getItem: (key => {
            let result = get(key);
            try {
                result = JSON.parse(result);
            } catch (e) {
                console.log(`Exception when trying parce value ${result} from local storage with requested key ${key}`);
                console.log(e);
            }
            return result;
        }).bind(this),

        setItem: ((key, value) => {
            try {
                value = JSON.stringify(value);
                set(key, value);
            } catch (e) {
                console.log(`Exception when trying set value in local storage with key ${key} and value ${value}`);
                console.log(e);
                return false;
            }
            return true;
        }).bind(this),

        addValue: ((arrKey, value, inTheEndOfArr = true) => {
            const target = this.getItem(arrKey);//todo this
            if (target.isArray()) {
                if (inTheEndOfArr) {
                    target.push(value);
                } else {
                    target.unshift(value);
                }
            }
            this.setItem(target);
            return target;
        }).bind(this),

        getAuthStatus: (() => {
            return this.getItem("authFlag") === null ? false : true;
        }).bind(this),

    }
}();

export var lSDecorator = function getLSDecorator() {
    const get = localStorage.getItem;
    const set = localStorage.setItem;
    localStorage.prototype.get = (key => {
        let result = get(key);
        try {
            result = JSON.parse(result);
        } catch (e) {
            console.log(`Exception when trying parce value ${result} from local storage with requested key ${key}`);
            console.log(e);
        }
        return result;
    }).bind(this)
    localStorage.prototype.set = ((key, value) => {
        try {
            value = JSON.stringify(value);
            set(key, value);
        } catch (e) {
            console.log(`Exception when trying set value in local storage with key ${key} and value ${value}`);
            console.log(e);
            return false;
        }
        return true;
    }).bind(this)
    localStorage.prototype.addValue = ((arrKey, value, inTheEndOfArr = true) => {
        const target = this.getItem(arrKey);//todo this
        if (target.isArray()) {
            if (inTheEndOfArr) {
                target.push(value);
            } else {
                target.unshift(value);
            }
        }
        this.setItem(target);
        return target;
    }).bind(this);

    localStorage.prototype.getAuthStatus = (() => {
        return this.getItem("authFlag") === null ? false : true;
    }).bind(this)
}();