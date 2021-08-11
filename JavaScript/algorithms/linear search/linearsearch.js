// O(n) worst case, returns -1 if value is not found
function linearSearch(arr, val) {
    for(let i = 0; i < arr.length; ++i) {
        if(arr[i] === val) return i;
    }
    return -1;
}

console.log(linearSearch([1, 2, -1, 4, "gabriel", 4, true], true));
console.log(linearSearch([1, 2, -1, 4, "gabriel", 4, true], "gabriel"));
console.log(linearSearch([1, 2, -1, 4, "gabriel", 4, true], -3));