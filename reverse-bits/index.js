var reverseBits = function(n) {
    let reversedArray = n.toString(2).split("").reverse();

    while(reversedArray.length < 32){
        reversedArray.push('0');
    }

    return parseInt(reversedArray.join(""), 2);
};


console.log(reverseBits(011111001))