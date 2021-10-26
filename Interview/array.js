var randomArray = () => {
  let resultArray = [];

  for (i = 0; i < 5; i++) {
    let randomNumber = Math.floor(Math.random() * 10);
    resultArray.push(randomNumber);
  }

  return resultArray;
};

var sumoofArray = randomArray().map((x) => x + x);

console.log(randomArray());
console.log(sumoofArray);
