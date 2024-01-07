# Gráfok

1. [Bevezető](#gráfok-nem-formálisan)
    1. A [Irányítás](#irányítás): 
        - Példa irányított gráfra: [Levelezés](#példa-irányított-gráfra)
        - Példa irányítatlan gráfra: [Bajnokság](#példa-irányítatlan-gráfra)
    3. [Súlyozás](#súlyozás):
        - Példa súlyozott gráfra: [Ősagárd környéke](#példa-súlyozott-gráfra)
    4. [Többszörös élek, színezések, hurokélek, izolált csúcsok](#többszörös-élek-színezések-hurokélek-izolált-csúcsok)
        - Példa színezésre, többszörös élre, hurokra és izolált csúcsra: [Közlekedés a László körül](#példa-színezésre-hurokélre-izolált-csúcsra-többszörös-élre)
2. [Gráfreprezentációk](grafreprezentaciok/): A három fő reprezentáció
3. [Algoritmusok](algoritmusok): A főbb gráfokhoz kapcsolódó programozási tételek

## Gráfok nem formálisan

Általában az olyan jelenségeket próbáljuk gráfokként formalizálni, amelyek ábrázolása során **csomópontokat** (**csúcsokat**) rajzolunk és amelyeket valamilyen módon **összekötünk**. Az összeköttetéseket általában **éleknek** nevezzük. 

Fontos viszont, hogy a csúcsok helyzete, egymástól való távolsága általában lényegtelen, az összeköttetéseik az egyetlen fontos tulajdonságaik.

### Irányítás
Léteznek irányítatlan gráfok és irányított gráfok. Az irányított gráfoknál nyilakat, az irányítatlan gráfoknál pedig egyszerű vonalakat rajzolunk az ábráinkban: 
#### Példa irányított gráfra
Egy baráti társaság levelezése. A csúcsok az emberek, a nyilak pedig azt mutatják, hogy ki küldött kinek levelet. 

![Levelezésről készült irányított gráf](levelezes.jpg)

*Ha az egyik ember küldött levelet egy másiknak, még nem biztos, hogy ez visszafele is igaz, ezért fontos az irányítás jelzése.*


#### Példa irányítatlan gráfra
Egy bajnokság pillanatnyi állása. A csúcsok a csapatok, az élek pedig az, hogy játszottak-e már egymással. 

![Bajnokságról készült irányítatlan gráf](bajnoksag.jpg)


*Ha az egyik játszott a másikkal, akkor nyilván a másik is játszott az egyikkel, tehát nincs értelme megkülönböztetni a élek irányát...*

### Súlyozás
Léteznek súlyozott és nem súlyozott gráfok. A fenti két példa (levelezés és bajnokság) mindegyike súlyozatlan gráfra példa. Léteznek azonban súlyozott gráfok is, ahol az élek valamilyen számszerű értékkel is bírnak. De itt egy példa egy súlyozott, irányítatlan gráfra: 

#### Példa súlyozott gráfra
Távolságok falvak között. A csúcsok falvak, az összekötettés az autóval való közvetlen megközelíthetőséget jelenti. Az élekre felírjuk azt is, hogy pontosan hány kilométerről van szó -- ezek az élek súlyai. Ez ebben az esetben egy pozitív valós számot jelent, de ez nem minden súlyozott gráfra igaz.

[![Ősagárd környéki kéktúrában érintett falvak súlyozott irányítatlan gráfja](osagard.jpg)](https://dreampuf.github.io/GraphvizOnline/#graph%20G%20%7B%0A%0A%20%20%0A%C5%90sag%C3%A1rd%20--%20N%C5%91tincs%20%5Blabel%20%3D%20%226.1%22%2C%20weight%20%3D%206.1%5D%3B%0A%C5%90sag%C3%A1rd%20--%20Fels%C5%91pet%C3%A9ny%20%5Blabel%20%3D%20%226.2%22%2C%20weight%20%3D%206.2%5D%3B%0AFels%C5%91pet%C3%A9ny%20--%20Als%C3%B3pet%C3%A9ny%20%5Blabel%20%3D%20%224.6%22%2C%20weight%20%3D%204.6%5D%3B%0AKeszeg%20--%20Als%C3%B3pet%C3%A9ny%20%5Blabel%20%3D%20%226.0%22%2C%20weight%20%3D%206.0%5D%3B%0A%C5%90sag%C3%A1rd%20--%20Keszeg%20%5Blabel%20%3D%20%225.1%22%2C%20weight%20%3D%205.1%5D%3B%0AN%C5%91tincs%20--%20Szendehely%20%5Blabel%20%3D%20%226.1%22%2C%20weight%20%3D%206.1%5D%3B%0AB%C3%A1nk%20--%20Fels%C5%91pet%C3%A9ny%20%5Blabel%20%3D%20%226.5%22%2C%20weight%20%3D%206.5%5D%3B%0AB%C3%A1nk%20--%20Als%C3%B3pet%C3%A9ny%20%5Blabel%20%3D%20%228.5%22%2C%20weight%20%3D%208.5%5D%3B%0AB%C3%A1nk%20--%20R%C3%A9ts%C3%A1g%20%5Blabel%20%3D%20%225.3%22%2C%20weight%20%3D%205.3%5D%3B%0AB%C3%A1nk%20--%20Romh%C3%A1ny%20%5Blabel%20%3D%20%226.9%22%2C%20weight%20%3D%206.9%5D%3B%0AR%C3%A9ts%C3%A1g%20--%20N%C5%91tincs%20%5Blabel%20%3D%20%229.9%22%2C%20weight%20%3D%209.9%5D%3B%0AR%C3%A9ts%C3%A1g%20--%20Szendehely%20%5Blabel%20%3D%20%2210.3%22%2C%20weight%20%3D%2010.3%5D%3B%0ABerkenye%20--%20N%C5%91tincs%20%5Blabel%20%3D%20%226.5%22%2C%20weight%20%3D%206.5%5D%3B%0AN%C3%B3gr%C3%A1d%20--%20Berkenye%20%5Blabel%20%3D%20%222.5%22%2C%20weight%20%3D%202.5%5D%3B%0ASzendehely%20--%20Berkenye%20%5Blabel%20%3D%20%226.9%22%2C%20weight%20%3D%206.9%5D%3B%0ARomh%C3%A1ny%3B%0A%7D)

### Többszörös élek, színezések, hurokélek, izolált csúcsok
#### Többszörös él
Előfordulhat, hogy két csúcs között egynél **több összeköttetés is adódik**. Ilyenkor azt mondjuk, hogy a két csúcs közt többszörös élek vannak. Például mert a város két pontja között busszal és villamossal is lehet közlekedni. 

Ez a helyzet nem feltétlenül váltható ki azzal, hogy súlyozzuk az éleket (ilyenkor pl. 2-őt írva az élre): Ha szeretnénk súlyozni az éleket, mert például a villamos gyorsabb, mint a busz, akkor egyszerűbb ezeket külön élekként (súlyok külön hordozóiként) felfogni. 


#### Példa színezésre, hurokélre, izolált csúcsra, többszörös élre

Folytatva az előző példát, akkor sem lehet mindig egyszerű súlyozással helyettesíteni a többszörös éleket, ha valaki **csak** villamossal utazva akar sok megállót megtenni. Ilyenkor nem elég neki az, hogy van *legalább egy* él: neki fontos, hogy az az él pontosan milyen, hiszen ő villamossal akar utazni.

Az ilyen gráfoknál **színezzük az éleket**, például a fenti ábrát úgy reprezentálhatnánk, hogy a kék élek jelölik a buszokat és a sárga élek a villamosokat:

[![3-as villamos és 9-es busz megállóinak részlete különböző színű éleket használva](buszvillamos.jpg)](https://dreampuf.github.io/GraphvizOnline/#graph%20G%20%7B%0A%0A%22Eg%C3%A9szs%C3%A9gh%C3%A1z%22%20--%20%22M%C3%A1zsa%20t%C3%A9r%22%20%5Bcolor%3Dblue%5D%3B%0A%22M%C3%A1zsa%20t%C3%A9r%22%20--%20%22Liget%20t%C3%A9r%22%20%5Bcolor%3Dblue%5D%3B%0A%22Liget%20t%C3%A9r%22%20--%20%22Szent%20L%C3%A1szl%C3%B3%20t%C3%A9r%22%20%5Bcolor%3Dblue%5D%3B%0A%22Szent%20L%C3%A1szl%C3%B3%20t%C3%A9r%22%20--%20%22K%C5%91b%C3%A1nya%20als%C3%B3%5Cnvas%C3%BAt%C3%A1llom%C3%A1s%22%20%5Bcolor%3Dblue%5D%3B%0A%0A%22%C3%96rs%20vez%C3%A9r%20tere%22%20--%20%22Feh%C3%A9r%20%C3%BAt%22%20%5Bcolor%3Dorange%5D%3B%0A%22Feh%C3%A9r%20%C3%BAt%22%20%20--%20%22Terebesi%20utca%22%20%5Bcolor%3Dorange%5D%3B%0A%22Terebesi%20utca%22%20--%20%22%C3%89lessarok%22%20%5Bcolor%3Dorange%5D%3B%0A%22%C3%89lessarok%22%20--%20%22%C3%93nodi%20utca%22%20%5Bcolor%3Dorange%5D%3B%0A%22%C3%93nodi%20utca%22%20--%20%22Szent%20L%C3%A1szl%C3%B3%20t%C3%A9r%22%20%5Bcolor%3Dorange%5D%3B%0A%22Szent%20L%C3%A1szl%C3%B3%20t%C3%A9r%22%20--%20%22Liget%20t%C3%A9r%22%20%5Bcolor%3Dorange%5D%3B%0A%22Liget%20t%C3%A9r%22%20--%20%22M%C3%A1zsa%20t%C3%A9r%22%20%5Bcolor%3Dorange%5D%3B%0A%22M%C3%A1zsa%20t%C3%A9r%22%20--%20%22Fert%C5%91%20utca%22%20%5Bcolor%3Dorange%5D%3B%0A%22Fert%C5%91%20utca%22%20--%20%22Ecseri%20%C3%BAt%22%20%5Bcolor%3Dorange%5D%3B%0A%22Ecseri%20%C3%BAt%22%20--%20%22Balk%C3%A1n%20utca%22%20%5Bcolor%3Dorange%5D%3B%0A%22Martinovics%20t%C3%A9r%22%3B%0A%22Eg%C3%A9szs%C3%A9gh%C3%A1z%22--%20%22Eg%C3%A9szs%C3%A9gh%C3%A1z%22%20%5Blabel%3D%22(bicikliz%C3%A9s%20a%20n%C3%A9pligetben)%22%5D%3B%0A%7D)

#### Hurokél
A fenti, közlekedéshez hasonló példában is elképzelhetőek akár olyan élek, amelyek ugyanonnan indulnak, ahova jutnak: ezek az ún. **hurokélek**. 

Példa lenne egy hurokélre az, amikor egy városnéző buszra ha felszáll az ember, akkor könnyen lehet, hogy ugyanoda érkezik meg a busz, mint ahonnan elindult, hiszen nem közlekedési céllal történt az utazás, hanem városnézési céllal. A fenti példában egy népligetbeli biciklizés szolgál kicsit erőltetett példáként a hurokélre.

#### Izolált csúcsok

Az olyan csúcsokat, amelyek nincsenek semmilyen összeköttetésben más csúcsokkal, izolált csúcsoknak nevezzük. Ezekre a fenti példában azok a helyek lennének, ahova nem lehet az érintett járművekkel eljutni, például a Martinovics térre (Budapest e megállókhoz közel eső mértani középpontjába).



### Szomszédsági listák


## Algoritmusok

A gráfokkal kapcsolatos algoritmusok azok, amelyek a gráfokon való munka során kihasználják a gráf belső szerkezetét -- az éleket. 

A gráfalgoritmusok bejárása, a gráfok csúcsainak feldolgozása mindig úgy működik, hogy 
- egy csúcsot feldolgozunk, és aztán 
- a következő feldolgozandó csúcs mindig csak egy más fedolgozott csúcs szomszédja lehet csak. 

A bejárási stratégiák abban különböznek, hogy az új bevett csúcsot mi alapján választjuk ki. 

- Szélességi bejárásnak (Breadth first search, BFS)nevezzük azt a bejárást, amikor azt a csúcsot dolgozzuk fel a feldolgozhatók közül, amelyik a legrégebbóta vár a sorára, azaz amely számára a legelőször vált lehetővé a feldolgozhatóság. A szélességi bbejárás során a soron következő csúcsok mindig a kiinduló csúcshoz lehető legközelebb eső csúcsok. A fenti okok miatt a feldolgozandó csúcsok egy Sor adatszerkezetben várnak majd mindig a sorukra, hogy feldolgozásra kerüljenek.
- Mélységi bejárásnak (Depth first search, DFS) nevezzük azt a bejárást, amikor aztacsúcsot dolgozzuk fel a feldolgozhatók közül, amelyik a legfrissebben került a feldolgozható csúcsok közé. A fenti okok miatt a feldolgozandó csúcsok ilyenkor mindig egy Verem adatszerkezetben tárolódnak majd, míg feldolgozásra nem kerülnek.
- Mohó bejárásnak nevezzük azt, amikor azt a csúcsot dolgozzuk fel a feldolgozhatók közül, amely amelyik valamilyen szempont szerint a legoptimálisabb választás. Az iménti okok miatt a feldolgozásra váró csúcsok mindig egy kupac/prioritási sor adatszerkezetben várnak majd mindiga feldolgozásra. Ilyenkor gyakran az egyelőre elérhetetlen csúcsokat is az adatszerkezetben tároljuk, végtelenül rossz prioritással súlyozva őket. 

### Mikor melyiket érdemes használni?
- Mohó bejárást használunk a súlyozott gráfokon legrövidebb élösszeget (legrövidebb útvonalat) kereső Dijkstra algoritmusban
- Szélességi bejárást használunk olyankor, amikor a bejárás megszakítható korábban és a megoldást a kiindulóponthoz közel keressük. Ilyen például az, amikor a nem súlyozott gráfokon keresünk legrövidebb útvonalat! 
- Mélységi bejárást használunk akkor, amikor a bejárás korábban is megszakítható és a megoldást a kiinduló csúcstól távol keressük -- hiszen a mélységi bejárás rögtön megpróbál távoli pontokhoz eljutni, ahol ha talál megoldást, előbb végez. Ha például tudjuk, hogy egy gráfban a kiindulási ponttól legalább 9 lépésre kell menni, hogy a keresés befejeződhessen, akkor egy DFS keresés ezt akár 9 lépés után is képes megtalálni. Ugyanezt a csúcsot a BFS stratégia csak azután tudja megtalálni, hogy már minden legfeljebb 8 lépésre lévő csúcsot feldolgozott!

### Szélességi és mélységi bejárás
A szélességi bejárás csak abban különbözik egymástól, hogy vermet vagy sort használunk-e tárolónak. Ezért az algoritmusban csak Tárolóként hivatkozunk rájuk

A bejárások nagyon különböznek aszerint, hogy keresési, kiválogatási, összegzési, maximumkiválasztási, legrövidebb út keresési fealdatokat oldunk-e meg velük. De a közös rész hasonló, ezért a következőkben egyalgoritmus-sémát osztunk csak meg, és a későbbiekben tárgyaljuk csak a specifikus algoritmusokat.
```
Függvény Bejárás(innen:Egész, ...): ...
    Globális: 
        N: Egész  # csúcsok száma
        Szomszédai: Egész - Tömb[Egész]  # csúcsok szomszédait visszaadó függvény
    Lokális:
        tennivalok: Tároló
        allapot: Tömb[Egész]
        feldolgozando: Egész
    -----------------------
    INICIALIZÁLÁS

    tennivalok := új Verem[Egész]{innen}
    allapot := új Tömb[Egész](N db 0) 
    allapot[innen] := 1

    ... EGYÉB INICIALIZÁLÁSOK ...
    -----------------------
    Ciklus amíg nem tennivalók.Üres:
        feldolgozando := tennivalok.Kivesz()

        ... CSÚCS FELDOLGOZÁSA(feldolgozando) ...
        allapot[feldolgozando] := 2


        Iteráció sz eleme Szomszédai(innen):
            Ha allapot[sz] = 0:
                ... ÉL FELDOLGOZÁSA (feldolgozando, sz) ...
                tennivalok.Beletesz(sz)
                atmenet[sz] := szürke
            Elágazás vége
        Iteráció vége        
    Ciklus vége

... EREDMÉNY VISSZAADÁSA ... 

Függvény vége.

```

### Legrövidebb út