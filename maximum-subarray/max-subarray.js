var maxSubArray = function (nums) {
  let len = nums.length;
  let maxSum = -Infinity;
  let currSum;
  for (var i = 0; i < len; i++) {
    currSum = 0;
    for (var j = i; j < len; j++) {
      currSum += nums[j];
      if (maxSum < currSum) {
        maxSum = currSum;
      }
    }
  }
  return maxSum;
};

var nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
var results = maxSubArray(nums);

console.log(results);
