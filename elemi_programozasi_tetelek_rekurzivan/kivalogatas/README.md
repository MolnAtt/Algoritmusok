# Másolás

## Típusfeladat
Készítsd el az a megadott lista alapján azt a listát, amelyben csak a pozitív elemek szerepelnek!

## Általánosságban
A kiválogatáshoz mindig egy tulajdonságra, azaz egy predikátumra van szükség. Ezeket általában logikai értékű függvényekként reprezentáljuk, mikor a kiválogatási szempontot is paraméterként szeretnénk szerepeltetni a definícióban.

## Specifikáció

Ennek a programozási tételnek nehéz a specifikációja, mert úgy adjuk meg, hogy a kiszámítandó függvény egyértelmű legyen: a kiválogatott elemek egymáshoz viszonyított sorrendje ugyanaz maradjon a kiválogatás után. Ezt kicsit körülményes megfogalmazni, ugyanis hivatkozni kell arra, hogy a kiválogatott elem "hol volt" a kiválogatás előtt.

Ehhez ún. ráképezőtömböket fogunk alkalmazni. Ezek lényegében olyan tömbök, amelyek az eredeti tömb transzformációját írják le: melyik elem hova kerül, vagy a másik oldal felől nézve: melyik kiválogatott elem honnan érkezett. A ki nem válogatott elemeket ezek a tömbök egy "undefined" helyre képezik. Mivel kevés most az undefined helyre a lehetőségünk (A -1 nem természetes szám!), erre a célra a kiválogatott lista méretét használjuk majd. 

**Definíció.** *(ráképezőtömb)*
Azt mondjuk hogy egy $t_1$ tömböt a $t$ tömb ráképezi $t_2$ tömbbe, ha 
- $t_1$ nagyobb vagy egyenlő méretű $t_2$-vel

$$ \mathbf N_{t_1} \geq \mathbf N_{t_2} $$

- $t_1$ és $t$ ugyanakkora

$$ \mathbf N_{t_1} = \mathbf N_t $$

- $t$ minden értéke kisebb vagy egyenlő, mint $t_2$ mérete.

$$ A(t, t_2) \overset{\mathrm{def}}{\iff} (\forall i \in [0..\mathbf N_{t})) t[i]\leq \mathbf N_{t_2}$$

- $t_2$ minden $e$ értékéhez olyan $i_2$ index tartozik, amelyet $t$ felvesz egy olyan $i_1$ indexen, amelyen $t_1$ ugyanezt az $e$ értéket veszi fel.

$$ B(t_1, t, t_2)\overset{\mathrm{def}}{\iff} (\forall i_2 \in [0..\mathbf N_{t_2}))  (\exists i_1 \in [0..\mathbf N_{t_1}))  t[i_1] = i_2 \land t_1[i_1] = t_2[i_2]  $$

- $t$ minden $i$ helyen vagy $t_2$ méretét veszi fel, vagy pedig olyan $t[i]$ értékű, hogy azon a helyen $t_2[t[i]]$ megegyezik $t_1[i]$-gyel.
    
$$ C(t_1, t, t_2) \overset{\mathrm{def}}{\iff} (\forall i_1 \in [0..\mathbf N_{t_1}]) (t[i_1] = \mathbf N_{t_2} \lor t_1[i_1] = t_2[t[i_1]]  ) $$

$$\mathrm{Rakepez}(t_1, t, t_2) \overset{\mathrm{def}}{\iff} 
        \mathbf N_{t_1} \geq \mathbf N_{t_2} 
\land   \mathbf N_{t_1} = \mathbf N_t
\land   A(t, t_2)
\land   B(t_1, t, t_2)
\land   C(t_1, t, t_2)
$$

A Kivalogatas definíciójaként álló formula lent azt mondja, hogy létezik egy $t$ kapcsolat a két tömb indexei között, hogy 

- $t$ ráképezi $t_1$-et $t_2$-be
$$ \mathrm{Rakepez}(t_1, t, t_2)$$

- $t$ pontosan azokon a helyeken veszi fel a $t_2$ tömb méretét (így szimulálva azt, hogy nem válogatja ki), ahol $t_1$ nem $\varphi$-tulajdonságú értéket vesz fel. 

$$ \mathrm{Elhagy}_\varphi(t_1,t,t_2) \overset{\mathrm{def}}{\iff} (\forall i \in [0..\mathbf N_{t})) (\lnot \varphi (t_1[i]) \leftrightarrow t[i]= \mathbf N_{t_2} )$$

- A $t$ által létrehozott összeköttetés monoton növekvő abban az értelemben, hogy az összekapcsolt indexpárok közt a kisebb kezdőpontú kisebb végpontú.

$$ \mathrm{szmn}_{\varphi}(t_1,t,t_2) \overset{\mathrm{def}}{\iff} (\forall i,j \in [0..\mathbf{N}_{t})) ((i < j\land \varphi (t_1[i]) \land \varphi (t_1[j]) )\rightarrow t[i] < t[j]) $$


$$ \mathrm{Kivalogatas}_\varphi(t_1) = t_2 \overset{\mathrm{def}}{\iff} 
(\exists t ) 
(
    \mathrm{Rakepez}(t_1, t, t_2)
    \land \mathrm{Elhagy}(t_1, t, t_2)
    \land \mathrm{szmn}_\varphi(t_1, t, t_2)
)
$$


## Algoritmus
```
Függvény Kivalogat(t: tomb): lista
    Kivalogat = üres lista
    Iteráció t tömb e elemein:
        Ha 0<e:
            t.Hozzáad(e)
        Elágazás vége
    Iteráció vége
Függvény vége.
```
### Észrevételek:
- Az algoritmus működik üres listával is; ilyenkor üres lista a válasz.
### Összeépítések más programozási tételekkel
- Megszámlálás $\circ$ Kiválogatás: *Hány páros szám van a sorozatban?*
- Összegzés $\circ$ Kiválogatás: *Add meg a páros számok összegét!*
- Kiválogatás[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és hagyjuk el azokat, amelyek elemszáma nem éri el a 10-et!*
- Megszámlálás[Csoportosítás $\circ$ Kiválogatás]: *A megadott feltételek alapján csoportosítsuk a lista pozitív elemeit aszerint, hogy milyen számjegyre végződnek, és mondjuk meg, melyik csoportban hányan vannak!*

## Összeépítések más programozási tételekkel

## Implementáció
### C#
```cs
static List<double> Kivalogat(List<double> lista)
{
    List<double> result = new List<double>();
    foreach (double elem in lista)
    {
        if (0<elem)
        {
            result.Add(elem);
        }
    }
    return result;
}
```
### További implementációk
- [C#](kivalogatas.cs)
- [C++](kivalogatas.cpp)
- [JavaScript](kivalogatas.js)
- [Python](kivalogatas.py)



