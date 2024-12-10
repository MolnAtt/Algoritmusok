function osszeg1(lista){
    let sum = 0;
    for (const elem of lista) {
        sum += elem;
    }
    return sum;
}

function osszeg2(lista){
    let sum = 0;
    for (let i = 0; i < lista.length; i++) {
        sum += lista[i];
    }
    return sum;
}

let l = [1, 2, 3, 4, 5];
console.log(osszeg1(l));
console.log(osszeg2(l));
