function elsoi(lista){
    let i = 0;
    while (!(lista[i] < 0)){
        i++;
    }
    return i;
}

function elso1(lista){
    return lista[elsoi(lista)];
}

function elso2(lista){
    for (const elem of lista) {
        if (elem<0) {
            return elem;
        }
    }
}



let l = [4, 5, 1, -3, 2];
console.log(elsoi(l));
console.log(elso1(l));
console.log(elso2(l));
