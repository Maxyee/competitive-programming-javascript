// Find the maximum number in an array of numbers

function maximumNumber(array) {
  var max = array[0];

  for (var i = 0; i <= 10; i++) {
    if (array[i] > max) {
      max = array[i];
    }
  }

  return max;
}

var ar = [-5, 10, -3, 12, -9, 5, 90, 0, 1];
var max = findMax(ar);

console.log(max);
