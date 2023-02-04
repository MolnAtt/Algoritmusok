# Összegzés

## Típusfeladat
Keressük egy lista összes elemének összegét!

## Általánosságban
Ez a programozási tétel alkalmazható minden olyan helyzetben, amikor egy létező kétváltozós műveletet ki akarunk terjeszteni egy lista összes elemére. Azaz a + művelet esetén össze akarjuk adni a lista összes elemét.

Hasonló változatok még:
- számlista elemeinek a szorzata
- szöveglista elemeinek az egymás után írása (konkatenációja)

## Specifikáció
A feladat előfeltétellel bír:

- Feltesszük, hogy az összeadás értelmezve van az értékszorton. 

A feladat a következő függvény kiszámítása

- Szokásos jelöléssel:

$$ \mathrm{Osszeg}(t) \overset{\mathrm{def}}{=} \sum_{i\in [0..\mathbf N_t]} t[i]$$

- vagy primitív eszközökkel rekurzívan definiálva a nyelvben:

$$ \mathrm{Osszeg}([]) \overset{\mathrm{def}}{=} 0 
$$

$$\mathrm{Osszeg}([e|t]) \overset{\mathrm{def}}{=} e +\mathrm{Osszeg}(t)$$


(*Itt most el van kenve egy $\beta$-függvény lemma.*)
## Algoritmus
```
Függvény Összeg(t: Tömb[Szám]): Szám
    Összeg := 0
    Iteráció a t tömb e elemein:
        Összeg += e
    Iteráció vége
Függvény vége.
```
### Észrevételek
- Üres listára a fenti algoritmusok alkalmazhatók, arra 0 eredményt adnak. 

### Összeépítések más programozási tételekkel
- Összegzés $\circ$ Kiválogatás: Adjuk össze a lista megadott feltételnek megfelelő elemeit
- Összegzés[Csoportosításos]: A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport összegét!

## Implementációk
### C# Implementáció

#### Iterációval:
```cs
static double Osszeg(List<double> lista)
{
    double sum = 0;
    foreach (double elem in lista)
    {
        sum += elem;
    }
    return sum;
}
```

#### Számlálóciklussal
```cs
static double Osszeg(List<double> lista)
{
    double sum = 0;
    for (int i = 0; i < lista.Count; i++)
    {
        sum += lista[i];
    }
    return sum;
}
```
### További implementációk
- [C#](osszegzes.cs)
- [C++](osszegzes.cpp)
- [JavaScript](osszegzes.js)
- [Python](osszegzes.py)



