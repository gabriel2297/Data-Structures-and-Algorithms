function bubblesort(arr){
    for(let i = arr.length - 1; i > 0; --i) {
        for(let j = 0; j < i; ++j) {
            if(arr[j] > arr[j+1]) swap(arr, j, j+1);
        }
    }
    return arr;
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

let arr = [2, -1, 31, 21, 87, 4, 13, 74, 0];
printarray(arr);
bubblesort(arr);
printarray(arr);
