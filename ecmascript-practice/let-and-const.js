// Let and Const Keywords

// Let keywords
let a = 10;

function testMe() {
  let a = 20;
  console.log(a); // 20
}

console.log(a); // 10;

// Const keywords

const MY_CONST = "JavaScript";
console.log(MY_CONST); //JavaScript

MY_CONST = "ES6";
console.log(MY_CONST); // Error . const can not reassign

// In case of Object and Array

const myObject = { name: "Full Stack" };
myObject = { name: "Full Stack" }; // Type error constant variables.

// object key is not protected so we can run it
myObject.name = "backend only";

// ---- Array -----
const myArray = ["JavaScript", "React", "Node"];
// it is possible to push item to the
myArray.push("ES6");

// but assign a new array to myArray it's not possible
myArray = ["New Values"]; // this line will create error
