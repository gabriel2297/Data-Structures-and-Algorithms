# Data Structures and Algorithms in JavaScript
This repo contains the implementation of different data structures and algorithms in the JavaScript programming language

## Big O notation

Big O notation is used to know how good an algorithm behaves when its input increases in size and how good our algorithm implementation is when compared to other solutions.

- O(1) = Constant time, the operations done by the algorithm never change
- O(log n) = logarithmic time, 
- O(n) = Linear time, the operations done by the algorithm increment linearly as the size of n changes
- O(nˆ2) = Cuadratic time, the operations increase exponentially 

Exponents: 

- log2 (8)      = 3         --> 2ˆ3 = 8
- log2 (value)  = exponent  --> 2^exponent = value

## Approach to solving problems

What's an algorithm?
- Steps to perform a task. 

How to approach it? 
- Understand the problem
- Explore examples
- Break it down
- Solve/simplify
- Go back and refactor

Understanding the problem: 
1. Reinstate the problem in your own words
2. What inputs are taken by the problem
3. What's the output that's expected
4. Can the output be determined by the given inputs? 
5. How to label the pieces of data that are important to the problem

Example: write a function that takes two numbers and returns their sum

Reinstate the problem in your own words
- Implement a function that performs addition and returns the result 
What inputs are taken by the problem
- Two ints or floats
What's the output that's expected
- The sum of the ints or floats
Can the output be determined by the given inputs?
- Yes
How to label the pieces of data that are important to the problem
- num1, num2, result

```
function addition (num1: number, num2: number): number {
    return num1+num2;
}
```

Example: Write a function which takes in a string and returns counts of each character in the string

Reinstate the problem in your own words
- We want a function that returns the total times each character appears in a given word
What inputs are taken by the problem
- a word or words
What's the output that's expected
- a hash map with the letter counts
Can the output be determined by the given inputs?
- Yes
How to label the pieces of data that are important to the problem
- input, output

Explore examples: 
- What if the input is "hello world", do we ignore the space?
- What if the input is "hello 11234", do we ignore numbers or count them?
- What if the input is "Hello hi", do we store letters separately when they are uppercase vs lowercase?

Break it down: 
```
function wordCounter (input) {
    // define data structure that will hold the letter and the time it has appeared
    // loop through the input until we've read it all
    // check if the char is already in the data structure
        // if yes, increment its counter by one and move to the next letter
        // if no, put it inside the data structure and set its value to 1
    // return the data structure once you've finished processing words
}
```
Write it down: 
```
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
```

## Mastering common patterns to solve problems

### Frequency counter
Used to check if, for example, an array has all the same values in distinct order

Example: write a function called same that takes two arrays and checks if the second array contains the squared value of one of the values in the first array

Reinstate the problem in your own words
- We want to check if the values in the first array are contained in the second array as squared values.
What inputs are taken by the problem
- two arrays with different values as integeres
What's the output that's expected
- true or false
Can the output be determined by the given inputs?
- Yes
How to label the pieces of data that are important to the problem
- input, output

### Multiple pointers
Creating two or more pointers to move through the data until we get the value we want. This is used instead of two nested loops. 

For example, if we want to check if, within an array, two values in two different indexes sum to zero we can do: 

```
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
```

Or for example, moving the pointers one in front of the other

```
function countuniquevalues(arr) {
    if(arr.length == 1) return 1;
    if(arr.length == 0) return 0;
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
```

### Sliding window
Useful when looking for a subset of values that sum to something or that make up a result and checking for something that's continuous.

write a function called maxSubArraySum which accepts an array of integers and a number called n, the function should calculate the maximum sum of n consecutive elements in the array: 

```
function maxsubarraysum(arr, n) {
    let tempSum = 0, maxSum = 0;
    if(n > arr.length) {
        return null;
    }
    for(let i = 0; i < n; ++i) {
        maxSum += arr[i];
    }
    for(let i = n; i < arr.length; ++i) {
        tempSum = maxSum - arr[i - n] + arr[i];
        maxSum = Math.max(maxSum, tempSum);
        console.log(`${tempSum}  ${maxSum}`);
    }
    return maxSum;
}
```

### Divide and conquer
We use this algorithm to divide the problem, or breaking them into separate parts, and then checking if the solution is there or not. Used by many searching algorithms like binary search and such.


## Sorting

In this section we take a look at sorting, starting with bubble sort

### Bubble sort

Not that commonly used, but it's important to learn. The idea is that we're sorting in an ascending order, meaning bubbling up the largest elements to the right, leaving the smallest elements at the left. Bubble sort implementation [here](algorithms/bubble%20sort/bubblesort.js)

### Selection sort

Selection sort sorts in descending order. It passes through the array and looks for the smallest value, then places it in the beginning. Then it does the same for the second position, and so on. 
The complexity of it is O(n^2) because we're looping through the array several times and not just once. Selection sort implementation [here](algorithms/selection%20sort/selectionsort.js)

Selection sort does only the necessary swaps, so less writes, while bubble sort does a write (a swap) each time it compares data.







































