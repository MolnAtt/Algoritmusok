# Másolás

## Típusfeladat
Készítsd el az a megadott lista alapján azt a listát, amelyben a megfelelő helyeken az eredeti listában álló számok négyzetei szerepelnek! 

## Általánosságban
Ez a programozási tétel nem más, mint egy egyváltozós $f$ függvény kiterjesztése egy halmazra. A matematikában azt a kifejezést használják az $L$ listából készített $R$ listára, hogy az $R$ lista az $L$ lista $f$ *függvény szerinti képe*.

## Specifikáció

$$ \mathrm{Masolas}_f(t_1) = t_2 \overset{\mathrm{def}}{\iff} \mathbf N_{t_1}=\mathbf N_{t_2} \land (\forall i \in [0..\mathbf N_{t_1}))\; f(t_1[i]) = t_2[i] $$
ahol ebben az esetben most $f(x) = x ^2$.


Lambda-kalkulusal bővítve a nyelvet $f$ lehetne tárgynyelven is, ekkor azt lehetne mondani, hogy ez esetben $f=(\lambda x)\, x^2$

Megjegyezzük, hogy matematikában szokásos ezt a következő, rövidebb formában is jelölni:
$$ f[t] \overset{\mathrm{def}}= \mathrm{Masolas}_f(t) $$
ez nem okoz kétértelműséget az eddigi lekérdezéses jelöléssel, mert abba csak számterminusokat lehetett írni, tömbváltozókat nem.

Tehát a feladat az $f[t_1]=t_2$ függvény kiszámítására algoritmust írni, ahol $f$ a négyzetre emelés függvénye.

## Algoritmus
```
Függvény Masolas(t: tomb): tomb
    Masolas = üres tömb t-vel azonos méretben
    Ciklus i:=0-től t hosszáig:
        Masolas[i] = t[i] * t[i];
    Ciklus vége
Függvény vége.
```
### Észrevételek:
- Az algoritmus működik üres listával is; ilyenkor üres lista a válasz.


## Összeépítések más programozási tételekkel
- Összegzés $\circ$ Másolás: Add meg a számok négyzeteinek összegét!
- Másolás $\circ$ Kiválogatás: Add meg a pozitív számok négyzeteit!
- Megszámolás $\circ$ Kiválogatás $\circ$ Másolás: Hány olyan szám van, amelyek négyzete nagyobb, mint 100?
- Maximumkeresés $\circ$ Másolás: Mely számnak a legnagyobb a négyzete?

## Implementáció
### C#
#### Dinamikus tömbön
```cs
static List<double> Masolas(List<double> lista)
{
    List<double> result = new List<double>(lista.Count); // így kerülhető el a sok resize!
    foreach (double elem in lista)
    {
        result.Add(elem*elem);
    }
    return result;
}
```
#### Statikus tömbön
```cs
static double[] Masolas(double[] tomb)
{
    double[] result = new double[tomb.Length];
    for (int i = 0; i < tomb.Length; i++)
    {
        result[i] = tomb[i] * tomb[i];
    }
    return result;
}
```
### További implementációk
- [C#](masolas.cs)
- [C++](masolas.cpp)
- [JavaScript](masolas.js)
- [Python](masolas.py)



