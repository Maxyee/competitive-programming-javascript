// Create a function that receives an array of numbers and returns an array containing only the positive numbers

function getPositives(arr) {
  var arr2 = [];

  for (var i = 0; i < arr.length; i++) {
    var el = arr[i];

    if (el >= 0) {
      arr2.push(el);
    }
  }

  return arr2;
}

var arr = [-5, 10, -3, 12, -9, 5, 90, 0, 1];
var arr2 = getPositives(arr);

console.log(arr2);
