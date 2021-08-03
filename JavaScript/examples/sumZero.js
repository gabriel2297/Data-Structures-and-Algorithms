// only works for sorted arrays
function sumZero(arr){ 
    let left = 0;
    let right = arr.length - 1;
    let sum = 0;
    while(left < right) {
        sum = arr[left] + arr[right];
        if(sum == 0) { 
            return [arr[left], arr[right]]; 
        }
        else if (sum > 0) { 
            right--; 
        }
        else { 
            left++; 
        }
    }   
}

console.log(sumZero([-4, -3, -2, -1, 0, 1, 2, 1, 10]));