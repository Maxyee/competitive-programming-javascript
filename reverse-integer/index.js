var reverse = function(x) {
    const isNegative = x< 0 ? true : false;
    
    if (isNegative){
        x = x *-1;
    }
    
    let reversed = 0;
    while(x>0){
        reversed = (reversed * 10) + (x % 10);
        x = parseInt(x/10);
    }
    
    if(reversed > 2**31){
        return 0;
    }
    
    return isNegative? reversed * -1 : reversed;
};


console.log(reverse(120));  // output 