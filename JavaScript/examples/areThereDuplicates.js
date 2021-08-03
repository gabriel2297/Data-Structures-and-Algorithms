function areThereDuplicates() {
    let result = new Map();
    let temp;
    let dups = false;
    for(let i = 0; i < arguments.length; ++i) {
        temp = arguments[i];
        result.has(temp) ? dups = true : result.set(temp, "");
        if(dups) { break; }
    }
    return dups;
}

console.log(areThereDuplicates(1, 2, 3, 4));
console.log(areThereDuplicates(1, 2, 2, 4));
console.log(areThereDuplicates('a', 2, 'c', 'a'));