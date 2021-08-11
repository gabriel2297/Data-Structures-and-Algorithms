// write a function that accepts an array of positive integers and a positive integer
// the function should return the minimum length of a contiguous subarray of which the sum
// is greater or equal to the integer passed, return 0 if not found
console.log(minSubarrayLen([2,3,1,2,4,3], 7));
console.log(minSubarrayLen([2,1,6,5,4], 9));
console.log(minSubarrayLen([3,1,7,11,2,9,8,21,62,33,19], 52));
console.log(minSubarrayLen([1,4,16,22,5,7,8,9,10], 39));
console.log(minSubarrayLen([1,4,16,22,5,7,8,9,10], 55));
function minSubarrayLen(arr, n){
    let i = 0, j = 0, sum = 0, min = Number.MAX_SAFE_INTEGER;
    for(i; i < arr.length; ++i) {
        sum+=arr[i];
        while(sum >= n) {
            min = Math.min(min, i-j+1);
            sum-=arr[j];
            ++j;
        }
    }
    return min != Number.MAX_SAFE_INTEGER ? min : 0;
}