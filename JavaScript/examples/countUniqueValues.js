function countuniquevalues(arr) {
    if(arr.length <= 1) return 1;
    let counter = 0, leftPtr = 0, rightPtr = 1;
    while(rightPtr <= arr.length) {
        if(arr[rightPtr] != arr[leftPtr]) {
            counter++;
        }
        leftPtr++;
        rightPtr++;
    }
    return counter;
}

function countuniquevaluesmap(arr) {
    
}

console.log(countuniquevalues([1, 2, 3, 4, 5, 5, 5, 6, 7, 7, 7]));