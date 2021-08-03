function same(arr1, arr2) {
    if(arr1.length != arr2.length) { return false; }
    let arr1Map = {};
    let arr2Map = {};
    for(let i = 0; i < arr1.length; ++i) {
        arr1Map[arr1[i]] = (arr1Map[arr1[i]] || 0) + 1;
        arr2Map[arr2[i]] = (arr2Map[arr2[i]] || 0) + 1;
    }
    for(let val in arr1Map) {
        if(arr2Map[val ** 2] != arr1Map[val]) { return false; }
    }
    return true;
}

console.log(same([1, 1, 1, 4], [16, 4, 9, 16]));
console.log(same([1, 4, 2, 4], [16, 16, 4, 1]));
console.log(same([1, 2, 3], [2]));
console.log(same([4, 1, 3], [1, 9, 16]));