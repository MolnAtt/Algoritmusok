def helye1(lista):
    i = 0
    while i<len(lista) and not lista[i]<0:
        i+=1
    return i

def helye2(lista):
    for i, e in enumerate(lista):
        if e<0:
            return i
    return len(lista)

def keres(lista):
    h = helye1(lista)
    return -1 if h==len(lista) else h

def eldontes(lista):
    return helye1(lista)!=len(lista)

lvan = [4, 5, 1, -3, 2]
lnincs = [4, 5, 1, 3, 2]

print(helye1(lvan))
print(helye1(lnincs))
print(helye2(lvan))
print(helye2(lnincs))
print(keres(lvan))
print(keres(lnincs))
print(eldontes(lvan))
print(eldontes(lnincs))
