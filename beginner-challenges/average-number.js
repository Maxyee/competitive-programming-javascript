//  Calculate the average of the numbers in an array of numbers

function averageArray(ar) {
  var n = ar.length;
  var sum = 0;

  for (var i = 0; i < n; i++) {
    sum += ar[i];
  }

  return sum / n;
}

var ar = [1, 3, 9, 15, 90];
var avg = averageArray(ar);

console.log("Average :", avg);
