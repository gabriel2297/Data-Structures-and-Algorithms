function anagram(str1, str2) {
    if(str1.length != str2.length) { return false; }
    let map1 = {};
    let map2 = {};
    for(let i = 0; i < str1.length; ++i) {
        map1[str1[i]] = (map1[str1[i]] || 0) + 1;
        map2[str2[i]] = (map2[str2[i]] || 0) + 1;
    }
    for(let char of str1) {
        if(map1[char] != map2[char]) { return false; }
    }
    return true;
}

console.log(anagram('gabriel', 'leribag'));
console.log(anagram('gabriel has a blll', 'ball gabriel has a'));
console.log(anagram('test', 'jest'));