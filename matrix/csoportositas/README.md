# Csoportosítás

## Típusfeladatok
- **0..n intervallumra csoportosítás**: Csoportosítsd a listában szereplő számokat az utolsó számjegyük szerint!
- **tetszőleges értékhalmaz szerinti csoportosítás**: 
Csoportosítsd a listában szereplő karakterláncokat aszerint, hogy milyen milyen betűvel kezdődnek!


## Általánosságban
Ezekhez a feladatokhoz mindig egy függvényre van szükség, amely minden elemhez egyértelműen hozzárendel egy elemet. A feladat az lesz, hogy az ugyanazon értéket adó elemeket tegyük ugyanabba a csoportba. 

Fontos, hogy a feladat megoldása nem egy érték vagy egy értékeket tartalmazó tömb lesz, hanem 
- az első feladat esetében értékeket tartalmazó tömbök tömbje!
- a második feladat esetében értékeket tartalmazó tömbökből alkotott szótár, amiben a kulcsok a csoportosítási szempont értékei! 

Mivel a második általánosabb, a továbbiakban csak azzal foglalkozunk.

## Specifikáció

Az **Csoportosítás** feladat esetében egy, a csoportosítási szempontot megadó $f$ függvény esetében a következő reláció kiszámítására keresünk algoritmust.

$$ 
    \mathrm{Csoportosítas}_f(t) = tt
    \overset{\mathrm{def}}{\iff}
    (\forall k \in \mathrm{rng}_f(t))
    tt[k] = \mathrm{Kiválogat}_{\varphi_{f,k}}(t)
$$

Ahol két rövidítés jelentése:

$$ e \in \mathrm{rng}_f(t) 
    \overset{\mathrm{def}}{\iff} 
    (\exists i \in 0..\mathbf N_t) e = f(t[i])
$$

$\varphi_{f,k}$ pontosan azon elemekre teljesül, amelyekhez az $f$ függvény $k$-t rendel:

$$ \varphi_{f,k}(e) \overset{\mathrm{def}}{\iff}  f(e) = k$$

## Algoritmus
```
f: TÉrték -> TKulcs

Függvény Csoportosítás(t: Tömb[TÉrték]): Szótár[TKulcs, TÉrték]
    Lokális változók:
        kulcs: TKulcs

    Csoportosítás = üres Szótár[TKulcs,TÉrték]
    Iteráció t tömb e elemein:
        kulcs := f(e)
        Ha kulcs eleme Csoportosítás.Kulcsai-nak:
            Csoportosítás[kulcs].Hozzáad(e)
        Egyébként:
            Csoportosítás[kulcs] := [e]
        Elágazás vége
    Iteráció vége.
Függvény vége.
```
### Észrevételek:
- Az algoritmus működik üres listával, ilyenkor az eredmény egy üres szótár.
- A kulcsot nem mindig érdemes külön változóba elmenteni. Most azért van így, mert az általános algoritmusban nem tudjuk a ``f(e)`` függvénymeghívás számításigényét. A string első karakterének lekérdezése ebben a példában konstans, de lehetne komplexebb operációkat is végrehajtani. Ilyenkor hogy elkerüljük a többszöri végrehajtást, külön változóban egyszer érdemes kiszámolni.  

### Összeépítések más programozási tételekkel
- Helye[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és adjuk meg mindegyikben az első negatív elem pozícióját*
- Eldöntés[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és adjuk meg, hogy melyikben fordul elő negatív elem és melyikben nem!*
- Eldöntés[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és adjuk meg, hogy melyikben fordul elő negatív elem és melyikben nem!*
- Eldöntés[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és adjuk meg, hogy melyikben fordul elő negatív elem és melyikben nem!*
- Maximumkeresés\[Csoportosítás\]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport maximumát!*
- Megszámlálás[Csoportosítás]: *A megadott feltételek alapján csoportosítsuk a lista elemeit és számoljuk ki mindegyik csoport elemszámát!*

## Implementáció
### C#
```cs
static Dictionary<char, List<string>> Csoportosit(List<string> lista)
{
    Dictionary<char, List<string>> szotar = new Dictionary<char, List<string>>();
    foreach (string elem in lista)
    {
        char kulcs = elem[0];
        if (szotar.Keys.Contains(kulcs))
        {
            szotar[kulcs].Add(elem);
        }
        else
        {
            szotar[kulcs] = new List<string> { elem };
        }
    }
    return szotar;
}
```

Kivételesen a kiírást is szerepeltetjük, mert sokat elmond a szótárak használatáról: kulcsokon lehet iterálni, az értéket a kulccsal érdemes lekérdezni. (De lehet a párokon is iterálni, az talán gyorsabb is, de kevésbé olvasható.)
```cs
static void Main(string[] args)
{
    List<string> szavak = new List<string> { "répa", "retek", "mogyoró", "korán", "reggel", "ritkán", "rikkant", "a", "rigó"};

    Dictionary<char, List<string>> szotar = Csoportosit(szavak);
    foreach (char kulcs in szotar.Keys)
    {
        Console.WriteLine($"{kulcs}: " + string.Join(", ", szotar[kulcs]));
    }
}
```

### További implementációk
- [C#](csoportositas.cs)
- [C++](csoportositas.cpp) (figyelemre méltó, hogy itt nem kell elágazás!)
- [JavaScript](csoportositas.js)
- [Python](csoportositas.py)

