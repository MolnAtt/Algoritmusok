# Másolás

## Típusfeladat
Készítsd el az a megadott lista alapján azt a listát, amelyben a megfelelő helyeken az eredeti listában álló számok négyzetei szerepelnek! 

## Általánosságban
Ez a programozási tétel nem más, mint egy egyváltozós $f$ függvény kiterjesztése egy halmazra. A matematikában azt a kifejezést használják az $L$ listából készített $R$ listára, hogy az $R$ lista az $L$ lista $f$ *függvény szerinti képe*.

## Specifikáció

$$ \mathrm{Masolas}(f, L) = R \overset{\mathrm{def}}{\iff} \mathrm{Hossz}(L)=\mathrm{Hossz}(R) \land (\forall i \in [0..\mathrm{Hossz}(L)]) f(L[i]) = R[i] $$

ahol ebben az esetben most $f = (\lambda x) x^2$

## Implementáció

### Dinamikus tömbön
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
### Statikus tömbön
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
### Észrevételek:
- Az algoritmus működik üres listával is; ilyenkor üres lista a válasz.


## Összeépítések más programozási tételekkel
- Összegzés $\circ$ Másolás: Add meg a számok négyzeteinek összegét!
- Másolás $\circ$ Kiválogatás: Add meg a pozitív számok négyzeteit!
- Megszámolás $\circ$ Kiválogatás $\circ$ Másolás: Hány olyan szám van, amelyek négyzete nagyobb, mint 100?
- Maximumkeresés $\circ$ Másolás: Mely számnak a legnagyobb a négyzete?
