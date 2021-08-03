function contains(testString, string) {
    for(let i = 0, j = 0; j < string.length; ++j) {
        if(testString[i] == string[j]) {
            ++i;
            if(i == testString.length) {
                return true;
            }
        }
        else {
            i = 0;
        }
    }
    return false;
}

console.log(contains('hello', 'hello world'));
console.log(contains('sing', 'sting'));
console.log(contains('gabriel', 'my name is gabriel the major'));
console.log(contains('abc', 'abracadabra'));
console.log(contains('abc', 'acb'));