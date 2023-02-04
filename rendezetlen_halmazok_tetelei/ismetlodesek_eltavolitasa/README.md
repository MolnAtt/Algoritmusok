# Másolás

## Típusfeladat
Távolítsd el az ismétlődő elemeket a listából!

## Általánosságban
Ennek a tételnek az az elsődleges szerepe, hogy egy listából valami olyan listát faragjon, amivel modellezni lehetne a matematikában is használt halmazokat. Az ismétlődésmentes listákkal, avagy halmazokkal már lehet uniót, metszetet képezni, stb.  

## Specifikáció

$$ \mathrm{Ismetlodesmentes}(t)\overset{\mathrm{def}}{\iff} 
(\forall i,j\in [0..\mathbf N_t)) (i\neq j \rightarrow t[i] = t[j])
$$

### Észrevételek
A specifikáció gyakorlatilag azt mondja, hogy a t **injektív** parciális függvény.

## Algoritmus
A következő algoritmus megtartja az eredeti elemek egymáshoz viszonyított sorrendjét, azonban a folytonos elemvizsgálat miatt $n^2$ idő alatt fut le.
```
Függvény Ismétlődésmentes(t: Tomb): Lista
    Ismétlődésmentes := üres Lista
    Iteráció t tömb e elemein:
        Ha e nem eleme Ismétlődésmentes-nek:
            Ismétlődésmentes.Hozzáad(e)
        Elágazás vége
    Iteráció vége
Függvény vége.
```

A következő algoritmus nem tartja meg az eredeti elemek sorrendjét, hanem azokat sorbaállítva adja vissza (így viszont ideális rendezett halmazok előállításához, amikben gyorsabban is lehet majd keresni és dolgozni, lásd a rendezett halmazok algoritmusait). Az algoritmus $n\cdot \log_2n$ idejű is lehet, amennyiben gyors rendezést használ fel. 

```
Függvény Ismétlődésmentes(t: Tömb): Lista
    Ismétlődésmentes := RendezettIsmétlődésmentes(t.Rendezettje())
Függvény vége.
```

ahol 

```
Függvény RendezettIsmétlődésmentes(t: RendezettTömb): RendezettLista
    RendezettIsmétlődésmentes := üres RendezettTömb
    Ha t.Hossz < 2:
        RendezettIsmétlődésmentes := t.Másolata()
    Egyébként: 
        Ciklus i:= 1-től lista.Hossz-ig:
            Ha rendezett[i-1] != rendezett[i]:
                RendezettIsmétlődésmentes.Hozzáad(rendezett[i])
            Elágazás vége
        Ciklus vége
    Elágazás vége
```

A leggyorsabb mégis az ($n$ idejű), ha az elemeket elhelyezzük egy hasítótáblában, majd kivesszük őket onnan. Ez azonban az előzőektől eltérően megnövekedett memóriaigénnyel jár. Ezt itt most nem tárgyaljuk, mert ez inkább az adatszerkezekhez tartozik. 

### Észrevételek:
- Az algoritmus működik üres listával is; ilyenkor üres lista a válasz.


## Implementáció
### C#
#### eredeti sorrendet tartó $n^2$ idejű algoritmus
```cs
static List<double> Ismetlodesmentes1(List<double> lista)
{
    List<double> result = new List<double>();
    foreach (double elem in lista)
    {
        if (!result.Contains(elem))
        {
            result.Add(elem);
        }
    }
    return result;
}
```
#### rendezett listát adó $n \cdot \log_2n$ idejű algoritmus 
```cs
static List<double> Ismetlodesmentes2(List<double> lista)
{
    List<double> rendezett= new List<double>(lista);
    if (lista.Count < 2)
    {
        return rendezett;
    }

    rendezett.Sort();

    List<double> result = new List<double>(rendezett.Count);
    result.Add(rendezett[0]);

    for (int i = 1; i < rendezett.Count; i++)
    {
        if (rendezett[i-1] != rendezett[i])
        {
            result.Add(rendezett[i]);
        }
    }

    return result;
}
```
### További implementációk
- [C#](ismetlodesek_eltavolitasa.cs)
- [C++](ismetlodesek_eltavolitasa.cpp)
- [JavaScript](ismetlodesek_eltavolitasa.js)
- [Python](ismetlodesek_eltavolitasa.py)



