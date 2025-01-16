# Megszámlálás

## Típusfeladat
Hány eleme van a listának?

## Általánosságban
Azon programozási nyelvekben nem alkalmazható csak ez a tétel, amelyekben nincs vagy nem definiálható számtípus. Ilyen nemigen van. 

## Specifikáció
Feladat egy $t$ tömb $\mathbf N_t$ hosszának kiszámítása.
## Algoritmus
```
Függvény Megszamolas(t: Tömb): Egész
    Megszámolás := 0
    Iteráció a t tömb elemein:
        Megszámolás+=1;
    Iteráció vége
Függvény vége.
```

### Észrevételek:
- Az algoritmus működik üres listával is; ilyenkor 0 a válasz.


### Összeépítések más programozási tételekkel
- Megszámlálás $\circ$ Kiválogatás: *Hány páros szám van a sorozatban?*
- Megszámlálás $\circ$ Kiválogatás $\circ$ Másolás: *Hány olyan szám van, amelyek négyzete háromszámjegyű?*
- Megszámlálás[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport elemszámát!*
- Összegzés[Csoportosításos]: A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport összegét!

## Implementáció
A magas szintű programozási nyelvekben a lista elemszámát általában a lista adatszerkezetébe mindig elmentik. Nagyon kevés nyelv van, ahol ez nem így történik. A Prolog nyelvben pl. vannak listák, de csak számítással deríthető ki a listák elemszáma. A megszámolás tétel jelentősége inkább az összeépítésekben rejlik. Illetve: A programozási tétel nem (ennyire) triviális akkor, amikor nem listákkal dolgozunk, hanem például valamilyen stream-mel, pl. a konzolra beírogatott számokkal vagy fájlokkal, amelyek mérete nem tudható előre. 

### C#

A C# nyelven tehát könnyedén megválaszolható a típusfeladat kérdése:
```cs
lista.Count;
```

A következő implementációban tehát csak "úgy teszünk", mintha a lista elemszámához nem férnénk egyébként hozzá. A programozási tételek összeépítésekor, tehát utólag lesz értelme annak, hogy ezt az egyébként felesleges munkát most mégis elvégezzük. 

### Ha nem lenne elmentve a lista hossza...
```cs
static int Megszamolas(List<double> lista)
{
    int db = 0;
    foreach (double elem in lista)
    {
        db++;
    }
    return db;
}
```
### További implementációk
Ugyanezekkel a fenntartásokkal...
- [C#](megszamolas.cs)
- [C++](megszamolas.cpp)
- [JavaScript](megszamolas.js)
- [Python](megszamolas.py)



