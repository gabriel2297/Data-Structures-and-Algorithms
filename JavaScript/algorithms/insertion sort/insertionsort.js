function insertionsort(arr) {
    for(let i = 1; i < arr.length; ++i) {
        let j = i - 1;
        while(arr[i] < arr[j]) {
            swap(arr, i, j);
            --i;
            --j;
        }
    }
}

function swap(arr, idx1, idx2) {
    let temp = arr[idx1];
    arr[idx1] = arr[idx2];
    arr[idx2] = temp;
}

function printarray(arr) {
    let str = "";
    arr.map(x => {
        str += x + ", ";
    });
    console.log(str);
}

let arr = [19, 3, 12, 88, 26, -1, 0];
printarray(arr);
insertionsort(arr);
printarray(arr);