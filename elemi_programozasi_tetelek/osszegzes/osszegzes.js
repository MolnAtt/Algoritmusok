function Osszeg1(lista){
    sum = 0;
    for (const elem of lista) {
        sum += elem;
    }
    return sum;
}

function Osszeg2(lista){
    sum = 0;
    for (let i = 0; i < lista.length; i++) {
        sum += lista[i];
    }
    return sum;
}

l = [1, 2, 3, 4, 5];
console.log(Osszeg1(l));
console.log(Osszeg2(l));
