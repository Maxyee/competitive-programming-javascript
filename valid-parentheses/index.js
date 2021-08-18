var isValid = function(s) {
    
    const obj = {
        "(": ")",
        "{": "}",
        "[": "]",
    }

    const stack = [];

    for(const param of s) {
        if(obj.hasOwnProperty(param)) {
            stack.push(param)
        }
        else{
            const closeParam = stack.pop();
            if(param !== obj[closeParam]) {
                return false;
            }
        }
    }

    return stack.length === 0;
};


// Input: s = "([)]"
// Output: false