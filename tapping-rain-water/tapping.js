var trap = function (height) {
  if (!height || !height.length) {
    return 0;
  }

  let maxLeftWall = 0;
  let maxRightWall = 0;

  let water = 0;
  let i = 0;
  let j = height.length - 1;
  while (i < j) {
    if (height[i] < height[j]) {
      if (height[i] >= maxLeftWall) {
        maxLeftWall = height[i];
      } else {
        water += maxLeftWall - height[i];
      }
      i++;
    } else {
      if (height[j] >= maxRightWall) {
        maxRightWall = height[j];
      } else {
        water += maxRightWall - height[j];
      }
      j--;
    }
  }

  return water;
};

var height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
var result = trap(height);
console.log(result);
