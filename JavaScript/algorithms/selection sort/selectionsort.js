function selectionsort(arr){
    for(let i = 0; i < arr.length; ++i) {
        let min = i;
        for(let j = i+1; j < arr.length; ++j) {
            if (arr[j] < arr[min]) {
                min = j;
            }
        }
        if(min != i) swap(arr, i, min);
    }
}

function swap(arr, idx1, idx2) {
    let temp = arr[idx1];
    arr[idx1] = arr[idx2];
    arr[idx2] = temp;
}

function printarray(arr) {
    let str = "";
    for(let i = 0; i < arr.length; ++i){
        str += arr[i] + ", ";
    }
    console.log(str);
}

let arr = [10, 82, 32, 12, 8, 11];
printarray(arr);
selectionsort(arr);
printarray(arr);
