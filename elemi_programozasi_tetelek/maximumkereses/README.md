# Maximumkeresés

## Típusfeladat
Keressük egy lista legnagyobb elemét! 

Keressük egy lista legnagyobb elemének helyét!

## Általánosságban
Ez a programozási tétel alkalmazható minden olyan helyzetben, amikor létezik egy elemtípusban adott valamféle rendezés, pl. az egész számok esetében a <. A válasz az az elem lesz, amely <-értelemben nagyobb minden más elemnél. 

Hasonló változatok még:
- Minimumkeresés

## Specifikáció

A specifikáció során feltesszük, hogy az értékszorton létezik egy <-vel jelölt szigorú totális rendezés.

A maximális érték keresésekor a $t\mapsto \mathrm{max}\{ t[i] : i\in [0..\mathbf N_t)\}$ függvény kiszámítására keresünk algoritmust. Ez a függvény egyébként a tárgynyelven is definiálható.

$$ 
    \mathrm{max} (t) = m  
    \overset{\mathrm{def}}{\iff} 
    (\exists i_m) (t[i_m]=m\land \mathrm{maxi}(t, i_m))
$$
ahol 
$$ 
    \mathrm{maxi} (t, i_m) 
    \overset{\mathrm{def}}{\iff} 
    
    (\forall i \in [0..\mathbf N_t))\; t[i]\leq t[i_m]
$$

A maximális érték helyének keresésekor egy lehetséges $i$ értéket keresünk, amelyre $\mathrm{maxi} (t, i_m) $ igaz.




## Algoritmus
### Maximális érték keresése
```
Függvény Maximum(t: Tömb): Szám
    Maximum = t[0]
    Ciklus i:=1-től t hosszáig:
        Ha Maximum < t[i]:
            Maximum = t[i]
        Elágazás vége
    Ciklus vége
Függvény vége.
```

### Maximális érték helyének keresése
```
Függvény Maximum_indexe(t: Tömb): Egész
    Lokális változók:
        maximum: Szám

    maximum = t[0]
    Maximum_indexe = 0
    Ciklus i:=1-től t hosszáig:
        Ha maximum < t[i]:
            maximum = t[i]
            Maximum_indexe = i
        Elágazás vége
    Ciklus vége
Függvény vége.
```

### Észrevételek:
- Az algoritmus nem működik, ha üres listával dolgozunk. De üres lista esetén a kérdésnek sincs értelme.
- Figyeljünk oda arra, hogy a ciklus 1-től indul! Az eredmény ugyanaz, ha 0-tól indul, de egy teljesen felesleges számítást takar az egész


## Összeépítések más programozási tételekkel
- Maximumkeresés $\circ$ Kiválogatás: *Keressük egy lista adott feltételnek megfelelő elemei közül a legnagyobbat. Pl. Keressük a legnagyobb páros számot.*
- Maximumkeresés $\circ$ Másolás: *Keressük egy lista adott függvény szerinti képének legnagyobb elemét. Pl. Keressük azt a számot, amelynek a legnagyobb a négyzete (itt a negatív számok beelőzhetnek!).*
- Maximumkeresés\[Csoportosítás\]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport maximumát!*


## Megjegyzések
- ha az indexre és az értékre is szükségünk van, nem érdemes két változót visszaadó függvénnyel bajlódni. Ilyenkor keressük az indexet és az alapján kérjük le az értéket, ez ugyanis konstans idejű művelet. 

## Implementációk
### C#
#### Maximális érték keresése
```cs
static double Maximum(List<double> lista)
{
    double max = lista[0];
    for (int i = 1; i < lista.Count; i++)
    {
        if (max < lista[i])
        {
            max = lista[i];
        }
    }
    return max;
}
```

#### Maximális érték indexének keresése
```cs
static int Maximum_indexe(List<double> lista)
{
    double max = lista[0];
    int maxi = 0;
    for (int i = 1; i < lista.Count; i++)
    {
        if (max < lista[i])
        {
            max = lista[i];
            maxi = i;
        }
    }
    return maxi;
}
```
### További implementációk
- [C#](maximumkereses.cs)
- [C++](maximumkereses.cpp)
- [JavaScript](maximumkereses.js)
- [Python](maximumkereses.py)

