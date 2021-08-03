// write a function that accepts an array and returns the length of the longest
// substring with all distinct chars
/** Explanation: 
 * 1. seen is a set, which can only contain unique elements
 * 2. loop from left to the end of the string
 * 3. if the set already 
*/
function findLongestSubstring(arr){
    let seen = new Set();
    let i = 0, j = 0, max = 0;
    while(j < arr.length) {
        if(seen.has(arr[j])) {
            seen.delete(arr[i]);
            ++i;
        }
        else {
            seen.add(arr[j]);
            ++j;
            max = Math.max(seen.size, max);
        }
    }
    return max;
}

console.log(findLongestSubstring(""));
console.log(findLongestSubstring("rithmschool"));
console.log(findLongestSubstring("thisisawesome"));
console.log(findLongestSubstring("thecatinthehat"));
console.log(findLongestSubstring("bbbbbb"));
console.log(findLongestSubstring("longestsubstring"));
console.log(findLongestSubstring("thisishowwedoit"));