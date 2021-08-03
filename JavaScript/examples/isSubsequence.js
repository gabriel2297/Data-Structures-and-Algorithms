function isSubsequence(testString, string) {
    for(let i = 0, j = 0; j < string.length; ++j) {
        if(testString[i] == string[j]) {
            ++i;
            if(i == testString.length) {
                return true;
            }
        }
    }
    return false;
}

//   i
// sing  sting
//         j

console.log(isSubsequence('hello', 'hello world'));
console.log(isSubsequence('sing', 'sting'));
console.log(isSubsequence('abc', 'abracadabra'));
console.log(isSubsequence('abc', 'acb'));