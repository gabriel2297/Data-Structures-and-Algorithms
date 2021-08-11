// O(log n) worst and average case
// only works on sorted arrays
// returns the element if found, else -1
function binarySearch(arr, val) {
    let middle = Math.floor(arr.length/2);
    if(arr[middle] === val) return arr[middle];
    else if(arr[middle] > val && arr.length > 1) return binarySearch(arr.slice(0, middle), val);
    else if(arr[middle] < val && arr.length > 1) return binarySearch(arr.slice(middle+1, arr.length), val);
    else return -1;
}

// returns the index if found, else -1
function binarySearch2(arr, val) {
    let middle = 0;
    function doBinarySearch(start, end) {
        middle = Math.floor((start+end)/2);
        if(arr[middle] === val) return middle;
        if(arr[middle] > val && (end-start) >= 1) return doBinarySearch(start, middle-1);
        if(arr[middle] < val && (end-start) >= 1) return doBinarySearch(middle+1, end);
        return -1;
    }
    return doBinarySearch(0, arr.length-1);
}

console.log(binarySearch([1,2,3,4,5], 2));
console.log(binarySearch([0,2,3,6,8,10,12,18,22,35], 7));
console.log(binarySearch([0,2,3,6,8,10,12,18,22,35], 22));
console.log(binarySearch([0,2,3,6,8,10,12,18,22,35], 8));
console.log(binarySearch([0,2,3,6,8,10,12,18,22,35], 303));
console.log(binarySearch([0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30], 18));