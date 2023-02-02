function megszamolas(lista){
    let db = 0;
    for (const elem of lista) {
        db++;
    }
    return db;
}


let l = [4, 5, 1, 3, 2];
console.log(l.length);
console.log(megszamolas(l));
