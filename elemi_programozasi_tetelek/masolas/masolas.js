function masolas(lista){
    let result = Array(lista.length);
    for (let i = 0; i < result.length; i++) {
        result[i] = lista[i]*lista[i];
    }
    return result;
}


let l = [4, 5, 1, 3, 2];
console.log(masolas(l));
