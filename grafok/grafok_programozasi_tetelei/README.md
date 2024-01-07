# Gráfok programozási tételei

1. [Gráfok bejárása](#gráfok-bejárása)
    

A gráfokkal kapcsolatos algoritmusok azok, amelyek a gráfokon való munka során kihasználják a gráf belső szerkezetét -- az éleket. 

## Gráfok bejárása

A gráfalgoritmusok bejárása, a gráfok csúcsainak feldolgozása mindig úgy működik, hogy 
- egy csúcsot feldolgozunk, és aztán 
- a következő feldolgozandó csúcs mindig csak egy más fedolgozott csúcs szomszédja lehet csak. 

Fontos tehát, hogy a gráfok bejárása mindig egy csúcsból indulva történik, és csak összefüggő gráfok esetén lehet előbb vagy utóbb hozzáférni így az összes csúcshoz!

A bejárási stratégiák abban különböznek, hogy az új bevett csúcsot mi alapján választjuk ki. 

- **Szélességi bejárásnak** (Breadth first search, BFS)nevezzük azt a bejárást, amikor azt a csúcsot dolgozzuk fel a feldolgozhatók közül, amelyik a legrégebbóta vár a sorára, azaz amely számára a legelőször vált lehetővé a feldolgozhatóság. A szélességi bbejárás során a soron következő csúcsok mindig a kiinduló csúcshoz lehető legközelebb eső csúcsok. A fenti okok miatt a feldolgozandó csúcsok egy Sor adatszerkezetben várnak majd mindig a sorukra, hogy feldolgozásra kerüljenek.
- **Mélységi bejárásnak** (Depth first search, DFS) nevezzük azt a bejárást, amikor aztacsúcsot dolgozzuk fel a feldolgozhatók közül, amelyik a legfrissebben került a feldolgozható csúcsok közé. A fenti okok miatt a feldolgozandó csúcsok ilyenkor mindig egy Verem adatszerkezetben tárolódnak majd, míg feldolgozásra nem kerülnek.
- **Mohó bejárásnak** nevezzük azt, amikor azt a csúcsot dolgozzuk fel a feldolgozhatók közül, amely amelyik valamilyen szempont szerint a legoptimálisabb választás. Az iménti okok miatt a feldolgozásra váró csúcsok mindig egy kupac/prioritási sor adatszerkezetben várnak majd mindig a feldolgozásra. Ilyenkor gyakran az egyelőre elérhetetlen csúcsokat is az adatszerkezetben tároljuk, végtelenül rossz prioritással súlyozva őket. 

### Mikor melyiket érdemes használni?
- Mohó bejárást használunk a súlyozott gráfokon legrövidebb élösszeget (legrövidebb útvonalat) kereső Dijkstra algoritmusban
- Szélességi bejárást használunk olyankor, amikor a bejárás megszakítható korábban és a megoldást a kiindulóponthoz közel keressük. Ilyen például az, amikor a nem súlyozott gráfokon keresünk legrövidebb útvonalat! 
- Mélységi bejárást használunk akkor, amikor a bejárás korábban is megszakítható és a megoldást a kiinduló csúcstól távol keressük -- hiszen a mélységi bejárás rögtön megpróbál távoli pontokhoz eljutni, ahol ha talál megoldást, előbb végez. Ha például tudjuk, hogy egy gráfban a kiindulási ponttól legalább 9 lépésre kell menni, hogy a keresés befejeződhessen, akkor egy DFS keresés ezt akár 9 lépés után is képes megtalálni. Ugyanezt a csúcsot a BFS stratégia csak azután tudja megtalálni, hogy már minden legfeljebb 8 lépésre lévő csúcsot feldolgozott!
- Amikor a gráf bejárását nem lehet előbb megszakítani (nem keresés zajlik), nincs lényegi különbség a bejárások között.

### Szélességi és mélységi bejárás
A szélességi bejárás csak abban különbözik egymástól, hogy vermet vagy sort használunk-e tárolónak. Ezért az algoritmusban csak Tárolóként hivatkozunk rájuk

A bejárások nagyon különböznek aszerint, hogy keresési, kiválogatási, összegzési, maximumkiválasztási, legrövidebb út keresési fealdatokat oldunk-e meg velük. De a közös rész hasonló, ezért a következőkben egy algoritmus-sémát osztunk csak meg, és a későbbiekben tárgyaljuk csak a specifikus algoritmusokat.

A specifikus algoritmusok a NAGYBETŰVEL ÍRT részekben különböznek. 

A bejárás programozási tételben 6 ilyen kruciális pont lesz:

1. PARAMÉTEREK: Milyen egyéb paraméterekkel dolgozik a típusfeladat.
2. VISSZATÉRÉSI_TÍPUS: Milyen típusú érték a megoldás.
3. EGYÉB INICIALIZÁLÁS: A típusfeladat megoldására jellemző változóinicializálási utasítások
4. CSÚCS FELDOLGOZÁSA: A csúcsok feldolgozásával kapcsolatos utasítások
5. ÉL FELDOLGOZÁSA: Az élek feldolgozásával kapcsolatos utasítások
6. EREDMÉNY FELDOLGOZÁSA: Az eredmény feldolgozásával kapcsolatos utasítások, többnyire ez az eredmény visszaadására vonatkozó utasításokat jelenti.


```
Függvény Bejárás(innen:Egész, PARAMÉTEREK): VISSZATÉRÉSI_TÍPUS
    Globális: 
        N: Egész  # csúcsok száma
        Szomszédai: Egész - Tömb[Egész]  # csúcsok szomszédait visszaadó függvény
    Lokális:
        tennivalok: Tároló
        allapot: Tömb[Egész]
        feldolgozando: Egész

    tennivalok := új Verem[Egész]{innen}
    allapot := új Tömb[Egész](N db 0) 
    allapot[innen] := 1

    EGYÉB INICIALIZÁLÁS

    Ciklus amíg nem tennivalók.Üres:
        feldolgozando := tennivalok.Kivesz()

        CSÚCS FELDOLGOZÁSA
        allapot[feldolgozando] := 2


        Iteráció sz eleme Szomszédai(innen):
            Ha allapot[sz] = 0:
                ÉL FELDOLGOZÁSA
                tennivalok.Beletesz(sz)
                atmenet[sz] := 1
            Elágazás vége
        Iteráció vége        
    Ciklus vége

    EREDMÉNY VISSZAADÁSA

Függvény vége.

```


## Hagyományos programozási tételek gráfokon


Ide tartoznak a listákon megismert programozási tételek átiratai

### Eldöntés
Van-e P tulajdonságú csúcs a gráfban?

### Keresés
Keressük a P tulajdonságú csúcsot.

### Kiválogatás
Adjuk meg az összes P tulajdonságú csúcsot!

### Összegzés
Adjuk össze az összes elérhet
