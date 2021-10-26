let range = 3;

function factorial(range) {
  if (range < 0) {
    return -1;
  } else if (range == 0) {
    return 1;
  } else {
    return range * factorial(range - 1);
  }
}

console.log(factorial(range));
