## Algoritmus

```
Függvény Logaritmikusan_Helye(T:Tömb[Egész], x:Szám):Egész
    Lokális változók:
        Egész e
        Egész v
        Egész k
    
    e:= 1
    v:= T.Hossz

    Ciklus:
        k:= (e+v) // 2  { egész értékű osztás, amely lefele kerekít }
        Ha T[k] < x, akkor
            e:= k+1 
        Egyébként ha T[k] > x, akkor
            v:= k-1
        Elágazás vége
    Amíg ( e<=v és T[k]!=x )
    Ciklus vége
    Ha T[k]==x, akkor
        Logaritmikusan_Helye := k
    Egyébként
        Logaritmikusan_Helye := e
    Elágazás vége
Függvénye vége.
```