function Maximum(lista){
    max = lista[0];
    for (let i = 1; i < lista.length; i++) {
        if (max < lista[i]) {
            max = lista[i];
        }
    }
    return max;
}

function Maximum_indexe(lista){    
    max = lista[0];
    maxi = 0;
    for (let i = 1; i < lista.length; i++) {
        if (max < lista[i]) {
            max = lista[i];
            maxi = i;
        }
    }
    return maxi;
}

l = [4, 5, 1, 3, 2];
console.log(Maximum(l));
console.log(Maximum_indexe(l));
