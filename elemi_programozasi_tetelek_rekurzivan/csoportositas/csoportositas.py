def csoportositas(lista):
    szotar = {}
    for elem in lista:
        kulcs = elem[0]
        if kulcs in szotar.keys():
            szotar[kulcs].append(elem)
        else:
            szotar[kulcs] = [elem]
    return szotar

szavak = ['répa', 'retek', 'mogyoró', 'korán', 'reggel', 'ritkán', 'rikkant', 'a', 'rigó']
szotar = csoportositas(szavak)
for kulcs in szotar.keys():
    print(f'{kulcs}: {szotar[kulcs]}')