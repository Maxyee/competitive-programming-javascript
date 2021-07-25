# Reverse Bits (Problem)

Example 1:

Input: n = 00000010100101000001111010011100
Output: 964176192 (00111001011110000010100101000000)
Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.

# Reverse Bits (Solution)

```js
var reverseBits = function (n) {
  let reversedArray = n.toString(2).split("").reverse();

  while (reversedArray.length < 32) {
    reversedArray.push("0");
  }

  return parseInt(reversedArray.join(""), 2);
};
```
