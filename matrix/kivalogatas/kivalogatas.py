def kivalogat(lista):
    result = []
    for elem in lista:
        if 0<elem:
            result.append(elem)
    return result

l = [-4,5,-1,-3,2]

print(kivalogat(l))
# bár ezt pythonban list comprehension-nel szoktuk.
print([x for x in l if 0<x])
