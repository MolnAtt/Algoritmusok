# Maximumkeresés

## Típusfeladat
Keressük egy lista legnagyobb elemét! 

## Általánosságban
Ez a programozási tétel alkalmazható minden olyan helyzetben, amikor létezik egy elemtípusban adott valamféle rendezés, pl. az egész számok esetében a <. A válasz az az elem lesz, amely <-értelemben nagyobb minden más elemnél. 

Hasonló változatok még:
- Minimumkeresés



## Implementáció

### Maximális érték keresése
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

### Maximális érték indexének keresése
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
### Észrevételek:
- Az algoritmus nem működik, ha üres listával dolgozunk. De üres lista esetén a kérdésnek sincs értelme.
- Figyeljünk oda arra, hogy a ciklus 1-től indul! Az eredmény ugyanaz, ha 0-tól indul, de egy teljesen felesleges számítást takar az egész


## Összeépítések más programozási tételekkel
- Feltételes maximumkeresés: Keressük egy lista adott feltételnek megfelelő elemei közül a legnagyobbat. Pl. Keressük a legnagyobb páros számot. 
- Sorozatszámítás utáni maximumkeresés: Keressük egy lista adott függvény szerinti képének legnagyobb elemét. Pl. Keressük azt a számot, amelynek a legnagyobb a négyzete (itt a negatív számok beelőzhetnek!).
- Csoportosításos maximumkeresés: A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport maximumát!


## Megjegyzések
- ha az indexre és az értékre is szükségünk van, nem biztos, hogy két változót visszaadó függvénnyel kell bajlódni. Ilyenkor keressük az indexet és az alapján kérjük le az értéket, ez ugyanis konstans idejű művelet. 