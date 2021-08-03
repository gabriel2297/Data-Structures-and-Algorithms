function averagePair(arr, avg){
    if (arr.length <= 1) return false;
    if (arr.length == 2) return (arr[0] + arr[1])/2 == avg ? true : false;
    let left = 0;
    let right = arr.length - 1;
    let average = 0;
    while(left < right) {
        average = (arr[left] + arr[right])/2;
        if(average > avg) {
            --right;
        }
        else if(average < avg) {
            ++left;
        }
        else {
            return true;
        }
    }
    return false;
}

console.log(averagePair([1,2,3], 2.5));
console.log(averagePair([1,3,3,5,6,7,10,12,19], 8));
console.log(averagePair([-1,0,3,4,5,6], 4.1));
console.log(averagePair([], 4));
