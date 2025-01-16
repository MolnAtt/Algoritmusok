def masolas(lista):
    result = []
    for elem in lista:
        result.append(elem*elem)
    return result

l = [4,5,1,3,2]

print(masolas(l))
# bár ezt pythonban list comprehension-nel szoktuk, ami valószínűleg gyorsabb is, mert kizárt, hogy resize-ol.
print([x*x for x in l])
