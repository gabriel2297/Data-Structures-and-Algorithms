// fib(4) // 3
// fib(10) // 55
// fib(28) // 317811
// fib(35) // 9227465
// 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
function fib(num){
    function doFib(num2) {
        if(num2 <= 1) return 1;
        return doFib(num2-1) + doFib(num2-2);
    }
    return doFib(num-1);
}

console.log(fib(4));