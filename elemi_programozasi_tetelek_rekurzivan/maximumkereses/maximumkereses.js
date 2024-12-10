function maximum(lista){
    let max = lista[0];
    for (let i = 1; i < lista.length; i++) {
        if (max < lista[i]) {
            max = lista[i];
        }
    }
    return max;
}

function maximumIndexe(lista){    
    let max = lista[0];
    let maxi = 0;
    for (let i = 1; i < lista.length; i++) {
        if (max < lista[i]) {
            max = lista[i];
            maxi = i;
        }
    }
    return maxi;
}

let l = [4, 5, 1, 3, 2];
console.log(maximum(l));
console.log(maximumIndexe(l));
