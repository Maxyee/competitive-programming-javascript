# Valid Parentheses

## Question

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
Example 4:

Input: s = "([)]"
Output: false
Example 5:

Input: s = "{[]}"
Output: true

# Answer

```js
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

```