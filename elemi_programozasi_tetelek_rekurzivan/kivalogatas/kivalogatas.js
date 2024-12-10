function kivalogat(lista){
    let result = [];
    for (const elem of lista) {
        if (0<elem) {
            result.push(elem);
        }
    }
    return result;
}


let l = [-4, 5, -1, -3, 2];
console.log(kivalogat(l));
