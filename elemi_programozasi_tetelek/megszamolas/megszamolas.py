def megszamolas(lista):
    db = 0
    for elem in lista:
        db+=1
    return db

l = [4,5,1,3,2]
print(len(l))
print(megszamolas(l))
