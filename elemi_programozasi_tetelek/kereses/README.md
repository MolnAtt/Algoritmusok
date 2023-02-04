# Lineáris keresés

## Típusfeladatok
- **Első helye**: 
Add meg a lista első negatív számának helyét! Amennyiben nincs ilyen, a válasz legyen a lista hossza maga!

- **Keresés:** Add meg a lista első negatív számának helyét! Amennyiben nincs ilyen, a válasz legyen -1!

- **Eldöntés:** Van-e negatív szám a listában?

## Általánosságban
Ezekhez a feladatokhoz mindig egy tulajdonságra, azaz egy predikátumra van szükség. Ezeket általában logikai értékű függvényekként reprezentáljuk, mikor a kiválasztási szempontot is paraméterként szeretnénk szerepeltetni a definícióban.

## Specifikáció

Az **Eldöntés** feladat esetében a következő reláció kiszámítására keresünk algoritmust.

$$ \mathrm{Van}_\varphi(t)
    \overset{\mathrm{def}}{\iff}
    (\exists i \in [0..\mathbf N_t)) \varphi(t[i])
$$

A **Helye** feladat esetében a következő függvény kiszámítására keresünk algoritmust.

$$ 
    \mathrm{Helye}_\varphi(t) = i  
    \overset{\mathrm{def}}{\iff}
    (\lnot \mathrm{Van}_\varphi (t) \land i = \mathbf N_t) \mathrel{\nabla}
    \mathrm{Elsoi}(t)=i
$$
ahol $\varphi \mathrel{\nabla} \psi$ jelöli kizáró vagyot, azaz 
$$\varphi \mathrel{\nabla} \psi \overset{\mathrm{def}}\iff \lnot \varphi \leftrightarrow \psi $$


A **Keresés** feladat esetében a következő függvény kiszámítására keresünk algoritmust.


$$ 
    \mathrm{Keres}_\varphi(t) = i  
    \overset{\mathrm{def}}{\iff}
    (\lnot \mathrm{Van}_\varphi (t) \land i = \mathbf -1) \mathrel{\nabla}
    \mathrm{Elsoi}(t)=i
$$


## Algoritmus
### Helye
```
Függvény Helye(t: Tömb): Természetes
    Helye := 0
    Ciklus amíg Helye < t.Hossz és nem t[Helye]<0:
        Helye+=1
    Ciklus vége
Függvény vége.
```

### Keresés
```
Függvény Keresés(t: Tömb): Egész
    Lokális változó:
        h : Természetes
    
    h = Helye(t)
    Keresés := -1 ha h=t.Hossz egyébként h
Függvény vége.
```

### Eldöntés
```
Függvény Eldöntés(t: Tömb): Logikai
    Eldöntés := Helye(t)=t.Hossz
Függvény vége.
```


### Észrevételek:
- Az algoritmus működik üres listával, de ilyenkor a feladattól függően lista hossza, -1 vagy hamis az eredmény.
### Összeépítések más programozási tételekkel
- Helye[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és adjuk meg mindegyikben az első negatív elem pozícióját*
- Eldöntés[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és adjuk meg, hogy melyikben fordul elő negatív elem és melyikben nem!*

## Összeépítések más programozási tételekkel

## Implementáció
### C#
#### Első helyének kiválasztása
```cs
static int Helye1(List<double> lista)
{
    int i = 0;
    while (i < lista.Count && !(lista[i] < 0))
    {
        i++;
    }
    return i;
}
```

Szintén szerepeltetjük a vitatott, iterációból való kilépéses változatot. A probléma megint az, hogy olyan hatása van a kódnak, mintha az illető a rendelkezésre álló eszközöket nem arra használná, amire azok valók. 

```cs
static int Helye2(List<double> lista)
{
    for (int i = 0; i < lista.Count; i++)
    {
        if (lista[i]<0)
        {
            return i;
        }
    }
    return lista.Count;
}
```

```cs
static int Keres(List<double> lista)
{
    int h = Helye1(lista);
    return h == lista.Count ? -1 : h;
}
```

```cs
static bool Eldontes(List<double> lista) => Helye1(lista) != lista.Count;
```

### További implementációk
- [C#](kereses.cs)
- [C++](kereses.cpp)
- [JavaScript](kereses.js)
- [Python](kereses.py)

