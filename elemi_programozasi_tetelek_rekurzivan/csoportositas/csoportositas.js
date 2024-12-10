function csoportositas(lista){
    let szotar = {};
    for (const elem of lista) {
        let kulcs = elem[0];
        if (szotar.hasOwnProperty(kulcs)) {
            szotar[kulcs].push(elem);
        } else {
            szotar[kulcs] = [elem];
        }
    }
    return szotar
}

let szavak = [ 'répa', 'retek', 'mogyoró', 'korán', 'reggel', 'ritkán', 'rikkant', 'a', 'rigó'];

let szotar = csoportositas(szavak);
for (const kulcs of Object.getOwnPropertyNames(szotar)) {
    console.log(`${kulcs}: ${szotar[kulcs]}`);
}
