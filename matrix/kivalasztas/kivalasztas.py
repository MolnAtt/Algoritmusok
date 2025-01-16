def elsoi(lista):
    i = 0
    while not lista[i]<0:
        i+=1
    return i

def elso1(lista):
    return lista[elsoi(lista)]

def elso2(lista):
    for elem in lista:
        if elem<0:
            return elem

l = [4, 5, 1, -3, 2]

print(elsoi(l))
print(elso1(l))
print(elso2(l))
