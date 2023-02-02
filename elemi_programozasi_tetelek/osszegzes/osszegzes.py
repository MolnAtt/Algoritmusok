def osszeg(lista):
    sum = 0
    for elem in lista:
        sum+=elem
    return sum

l = [1,2,3,4,5]
print(osszeg(l))