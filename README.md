# Algoritmusok jegyzet

## Listák programozási tételei

Minden elemi probléma két fő részre bontható: 

- Amikor végig kell nézni a listát: Összegzés, Maximumkeresés, Kiválogatás, ...
- És amikor nem: Keresés, Eldöntés, ...

### Végig kell nézni a listát
#### Összegzés

Ez a programozási tétel alkalmazható minden olyan helyzetben, amikor egy létező kétváltozós műveletet ki akarunk terjeszteni egy lista összes elemére. Azaz a + művelet esetén össze akarjuk adni a lista összes elemét.

```py
def osszeg(lista):
    sum = 0

    for elem in lista:
        sum += elem

    return sum
```

```cs
double Osszeg(List<double> lista)
{
    sum = 0;
    foreach(double elem in lista)
    {
        sum+=elem;
    }
    return sum;
}
```

##### Változatok: