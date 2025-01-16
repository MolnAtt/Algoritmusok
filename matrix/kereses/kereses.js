function helye1(lista){
    let i = 0;
    while (i<lista.length && !(lista[i] < 0)){
        i++;
    }
    return i;
}

function helye2(lista){
    for (let i=0; i<lista.length; i++){
        if (lista[i] < 0)
        {
            return i;
        }
    }
    return lista.length;
}

function keres(lista){
    let h = helye1(lista);
    return h==lista.length ? -1 : h;
}

function eldontes(lista){
    return helye1(lista)!=lista.length;
}

let lvan = [4, 5, 1, -3, 2];
let lnincs = [4, 5, 1, 3, 2];

console.log(helye1(lvan));
console.log(helye1(lnincs));
console.log(helye2(lvan));
console.log(helye2(lnincs));
console.log(keres(lvan));
console.log(keres(lnincs));
console.log(eldontes(lvan));
console.log(eldontes(lnincs));
