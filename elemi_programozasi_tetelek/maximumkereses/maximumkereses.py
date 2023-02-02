def maximum(lista):
    max = lista[0]
    for elem in lista[1:]:
        if max < elem:
            max = elem
    return max

def maximum_indexe1(lista):
    max = lista[0]
    maxi = 0
    for i, elem in enumerate(lista): # 0.elem is! A lista[1:] nem szép, mert másolat!
        if max < elem:
            max = elem
            maxi = i
    return maxi

def maximum_indexe2(lista):
    max = lista[0]
    maxi = 0
    i = 0
    while i<len(lista):
        if max < lista[i]:
            max = lista[i]
            maxi = i
        i+=1
    return maxi


l = [4,5,1,3,2]
print(maximum(l))
print(maximum_indexe1(l))
print(maximum_indexe2(l))