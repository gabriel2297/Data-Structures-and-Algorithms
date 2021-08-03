function maxsubarraysum(arr, n) {
    let tempSum = 0, maxSum = 0;
    if(n > arr.length) {
        return null;
    }
    for(let i = 0; i < n; ++i) {
        maxSum += arr[i];
    }
    for(let i = n; i < arr.length; ++i) {
        tempSum = maxSum - arr[i - n] + arr[i];
        maxSum = Math.max(maxSum, tempSum);
        console.log(`${tempSum}  ${maxSum}`);
    }
    return maxSum;
}

console.log(maxsubarraysum([1, 4, 2, 3, 8, -3, 2], 3));