# Algoritmusok jegyzet

## Listák programozási tételei

Minden elemi probléma két fő részre bontható: 

- Amikor végig kell nézni a listát: Összegzés, Maximumkeresés, Kiválogatás, ...
- És amikor nem: Keresés, Eldöntés, ...

### Végig kell nézni a listát
#### Összegzés

**típusfeladat:** Keressük egy lista összes elemének összegét.

Ez a programozási tétel alkalmazható minden olyan helyzetben, amikor egy létező kétváltozós műveletet ki akarunk terjeszteni egy lista összes elemére. Azaz a + művelet esetén össze akarjuk adni a lista összes elemét.

Hasonló változatok még:
- számlista elemeinek a szorzata
- szöveglista elemeinek az egymás után írása (konkatenációja)
- a maximumkeresés is  
- a kiválogatás is felfogható feltételes összegzésként: A nullelem az üres lista, a művelet pedig az unió.


Implementáció iterációval:
```cs
static double Osszeg1(List<double> lista)
{
    double sum = 0;
    foreach (double elem in lista)
    {
        sum += elem;
    }
    return sum;
}
```

Implementáció számlálóciklussal
```cs
static double Osszeg2(List<double> lista)
{
    double sum = 0;
    for (int i = 0; i < lista.Count; i++)
    {
        sum += lista[i];
    }
    return sum;
}
```

Összeépítések más programozási tételekkel:
- Feltételes összegzés: Adjuk össze a lista megadott feltételnek megfelelő elemeit
- Csoportosításos összegzés: A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport összegét!




##### Változatok: