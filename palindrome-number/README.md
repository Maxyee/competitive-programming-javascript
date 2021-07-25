# Palindrome Number (Problem)

Given an integer x, return true if x is palindrome integer.

An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.

Example 1:

Input: x = 121
Output: true

# Palindrome Number (Solution)

```js
// Two Pointer Method
var isPalindrome = function (x) {
  if (x < 0) {
    return false;
  }

  if (x < 10) {
    return true;
  }

  if (x % 10 === 0 && x !== 0) {
    return false;
  }

  const str = String(x);
  let i = 0,
    j = str.length - 1;

  while (i < j) {
    if (str[i] !== str[j]) {
      return false;
    }

    i++;
    j--;
  }

  return true;
};
```

- if X is negative ( not a palindrome )
- if X is less than ten ( always a palindrome )
- if X has 0 at its last digit and X is not 0 itself ( not a palindrome ) e.g. 10, 130 whose reverse will be 01, 031 respectively

- convert the number to a string
- take two pointers, at the start and end of the string
- if the digits at both pointers are different, it's not a palindrome
- we increment starting pointer and decrement the end pointer iteratively
- if the loop exits, then it was a palindrome
