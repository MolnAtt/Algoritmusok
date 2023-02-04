
# Kiválasztás

## Típusfeladat
- Van egy negatív szám a sorozatban. Melyik a első ilyen szám?

- Van egy negatív szám a sorozatban. Hol van az első ilyen szám?

## Általánosságban
A kiválasztáshoz mindig egy tulajdonságra, azaz egy predikátumra van szükség. Ezeket általában logikai értékű függvényekként reprezentáljuk, mikor a kiválasztási szempontot is paraméterként szeretnénk szerepeltetni a definícióban.

## Specifikáció

A feladat előfeltétellel bír: biztosan tudjuk, hogy van egy negatív szám a sorozatban. Ezt a megoldás során kihasználhatjuk. 

**Előfeltétel**

$$ \exists(i \in [0..\mathbf N_t)) \varphi(t[i])$$

ahol most $\varphi(x) \iff x<0$.

$$ 
    \mathrm{Elsoi}_\varphi(t) = i  
    \overset{\mathrm{def}}{\iff}
    \varphi(t[i]) \land (\forall i' \in [0..\mathbf N_t)) (\varphi(t[i'])\rightarrow i \leq i')
$$

$$ 
    \mathrm{Elso}_\varphi(t) = e  
    \overset{\mathrm{def}}{\iff}
    (\exists i) (\mathrm{Elsoi}_\varphi(t) = i \land t[i] = e)
$$

## Algoritmus
```
Függvény Kiválaszt(t: Tömb): Természetes
    Kiválaszt := 0
    Ciklus amíg nem t[Kiválaszt]<0:
        Kiválaszt+=1
    Ciklus vége
Függvény vége.
```

### Észrevételek:
- Az algoritmus nem működik üres listával, de ilyenkor az előfeltétel sem teljesül.
- A specifikációban rögzített előfeltétel biztosítja, hogy az algoritmus előbb utóbb véget ér. 
### Összeépítések más programozási tételekkel
- Kiválasztás[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és adjuk meg mindegyikben az első negatív elemet (amelyből biztosan lesz egy mindegyik csoportban)*

## Implementáció
### C#
#### Első helyének kiválasztása
```cs
static int Elsoi(List<double> lista)
{
    int i = 0;
    while (!(lista[i] < 0))
    {
        i++;
    }
    return i;
}
```

#### Első kiválasztása
```cs
        static double Elso1(List<double> lista) => lista[Elsoi(lista)];
```

Létezik egy vitatott megoldás is, amely egy iterációt megszakító visszatéréssel működik. Ezeket könnyű kódolni, viszont sokan nem szeretik -- rontja az olvashatóságot az olyan kód, amely azt igéri, hogy végigmegy a cikluson, de aztán mégis abbahagyja a munkát korábban.

```cs
        static double Elso2(List<double> lista)
        {
            foreach (double elem in lista)
            {
                if (elem < 0)
                {
                    return elem;
                }
            }
            return -1; // Ha az előfeltétel teljesül, ez elérhetetlen.
        }
```
Fontos, hogy amennyiben az előfeltétel teljesül, akkor az utolsó sor sosem futhat le. Azonban ez a sor C#-ban nem hagyható el, mert minden elágazásban kell legyen visszatérési pont.
### További implementációk
- [C#](kivalasztas.cs)
- [C++](kivalasztas.cpp)
- [JavaScript](kivalasztas.js)
- [Python](kivalasztas.py)

