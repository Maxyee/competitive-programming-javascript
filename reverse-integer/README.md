# Question (Reverse Integer)

Example 1:

Input: x = 123
Output: 321

Example 2:

Input: x = -123
Output: -321

Example 3:

Input: x = 120
Output: 21

Example 4:

Input: x = 0
Output: 0

# Soluton of Reverse Integer

```js
var reverse = function (x) {
  const isNegative = x < 0 ? true : false;

  if (isNegative) {
    x = x * -1;
  }

  let reversed = 0;
  while (x > 0) {
    reversed = reversed * 10 + (x % 10);
    x = parseInt(x / 10);
  }

  if (reversed > 2 ** 31) {
    return 0;
  }

  return isNegative ? reversed * -1 : reversed;
};
```
