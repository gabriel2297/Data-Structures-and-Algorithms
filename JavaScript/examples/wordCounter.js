function wordCounter (input) {
    let output = new Map();
    for(let i = 0; i < input.length; ++i) {
        if(!output.has(input[i])) {
            output.set(input[i], 1);
            continue;
        }
        output.set(input[i], (output.get(input[i]) + 1));
    }
    return output;
}

console.log(wordCounter("gabriel 123411 GABRIELAA"));w