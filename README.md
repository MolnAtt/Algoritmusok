# Algoritmusok jegyzet

## Listák programozási tételei

Minden elemi probléma két fő részre bontható: 

- Amikor végig kell nézni a listát: Összegzés, Maximumkeresés, Kiválogatás, ...
- És amikor nem: Keresés, Eldöntés, ...

### Végig kell nézni a listát
#### Összegzés

**Feladat:** Keressük egy lista összes elemének összegét.

Ez a programozási tétel alkalmazható minden olyan helyzetben, amikor egy létező kétváltozós műveletet ki akarunk terjeszteni egy lista összes elemére. Azaz a + művelet esetén össze akarjuk adni a lista összes elemét.

Hasonló változatok még:
- számlista elemeinek a szorzata
- szöveglista elemeinek az egymás után írása (konkatenációja)
- De a kiválogatás is egy feltételes összegzés: A nullelem az üres lista, a művelet pedig az unió.

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





| iterációval | számlálóciklussal |
| --- | --- |
| 
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
``` | 
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
 |


| iterációval | számlálóciklussal |
| --- | --- |
| `git status` | List all *new or modified* files |
| `git diff` | Show file differences that **haven't been** staged |


##### Változatok: