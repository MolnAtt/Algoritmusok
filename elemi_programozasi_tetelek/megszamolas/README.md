# Maximumkeresés

## Típusfeladat
Hány eleme van a listának?

## Általánosságban
Azon programozási nyelvekben nem alkalmazható csak ez a tétel, amelyekben nincs vagy nem definiálható számtípus. Ilyen nemigen van. 

## Specifikáció

### Formális specifikáció
lista hossza alatt következőképpen definiált függvényt értjük:

$$
\begin{array}{rcl}
    \mathrm{Hossz}([]) &=& 0
    \mathrm{Hossz}([x]+L) &=& Hossz(L) + 1
\end{array}
$$


## Implementáció
A magas szintű programozási nyelvekben a lista elemszámát általában a lista adatszerkezetébe mindig elmentik. Nagyon kevés nyelv van, ahol ez nem így történik. A Prolog nyelvben pl. vannak listák, de csak számítással deríthető ki a listák elemszáma. A megszámolás tétel jelentősége inkább az összeépítésekben rejlik. Illetve: A programozási tétel nem (ennyire) triviális akkor, amikor nem listákkal dolgozunk, hanem például valamilyen stream-mel, pl. a konzolra beírogatott számokkal vagy fájlokkal, amelyek mérete nem tudható előre. 

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
### Észrevételek:
- Az algoritmus működik üres listával is; ilyenkor 0 a válasz.


## Összeépítések más programozási tételekkel
- Feltételes megszámlálás: Hány páros szám van a sorozatban?
- Sorozatszámítás utáni megszámlálás: Hány olyan szám van, amelyek négyzete háromszámjegyű?
- Csoportosításos megszámlálás: A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport elemszámát!
