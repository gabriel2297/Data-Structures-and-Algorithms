function sameFrequency(num1, num2) {
    num1 = num1.toString();
    num2 = num2.toString(); 
    if(num1.length != num2.length) { return false; }
    let num1Result = {};
    let num2Result = {};
    for(let i = 0; i < num1.length; ++i) {
        num1Result[num1[i]] = num1Result[num1[i]] + 1 || 1;
        num2Result[num2[i]] = num2Result[num2[i]] + 1 || 1;
    }
    for(let num in num1Result){
        if(num1Result[num] != num2Result[num]) { return false; }
    }
    return true;
}

console.log(sameFrequency(182, 821));
console.log(sameFrequency(1828, 8213));