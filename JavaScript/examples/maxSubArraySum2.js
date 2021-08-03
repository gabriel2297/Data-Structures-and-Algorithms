function maxSubArraySum(arr, n) {
    if (arr.length < n) return null;
    let max = 0, temp = 0, i = 0;
    for(i; i < n; ++i) temp+=arr[i];
    for(i = n; i < arr.length; ++i) {
        temp = temp + arr[i] - arr[i-n];
        max = Math.max(max, temp);
    }
    return max;
}

console.log(maxSubArraySum([100,200,300,400], 2));
console.log(maxSubArraySum([1,4,2,10,23,3,1,0,20], 4));
console.log(maxSubArraySum([-3,4,0,-2,6,-1], 2));
console.log(maxSubArraySum([3,-2,7,-4,1,-1,4,-2,1], 2));
console.log(maxSubArraySum([2,3], 3));