function reverse(str){
    let reversed = "";
    
    function doReverse(str) {
        if(str.length == 0) return;
        if(str.length > 0) reversed += str.slice(-1);
        doReverse(str.slice(0, str.length-1));
    }

    doReverse(str);

    return reversed;
}
console.log(reverse('rithmschool'));
  
// reverse('awesome') // 'emosewa'
// reverse('rithmschool') // 'loohcsmhtir'