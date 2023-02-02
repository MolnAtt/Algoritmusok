def maximum(lista):
    max = lista[0]
    for elem in lista[1:]:
        if max < elem:
            max = elem
    return max

def maximum_indexe(lista):
    max = lista[0]
    maxi = 0
    for i, elem in enumerate(lista[1:]):
        if max < elem:
            max = elem
            maxi = i
    return maxi + 1


l = [4,5,1,3,2]
print(maximum(l))
print(maximum_indexe(l))