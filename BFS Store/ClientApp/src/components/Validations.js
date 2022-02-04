export const lengthValidatorCreator = (minLength, maxLenght) =>
    (value) =>
        value !== undefined && value.length < maxLenght && value.length > minLength
            ? undefined
            : `must be more then ${maxLenght} and less then ${minLength}`;

export const requireValidation = (value) => value ? undefined : "Required";


export const regexValidatorCreator = (regex, errorMsg) =>
    (value) =>
        regex.test(value)
            ? undefined
            : errorMsg;

export const passwordValidation = (value) => { //need refactor
    let errors = "";
    if (!/.*[a-z]/.test(value)) errors += "must contain at least 1 lowercase character\n";
    if (!/.*[A-Z]/.test(value)) errors += "must contain at least 1 uppercase character\n";
    if (!/.*[0-9]/.test(value)) errors += "must contain at least 1 numeric character\n";
    return errors === "" ? undefined : errors;
}



export const emailValidation =  regexValidatorCreator(/.+@\w+\..+/, "wrong email format");
export const phoneValidator =  regexValidatorCreator(/^[\d]+$/, "wrong phone format");

export const emailValidationTest = (regex) =>
    (value) =>
        regex.test(value)
            ? undefined
            : "wrong email format";