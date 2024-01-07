# Éllistás gráfreprezentáció
1. [Általában](#általában)
3. [MESTER](#mester)
4. [Graphviz](#graphviz)
5. [Matematikai definíció](#matematikai-definíció)
6. [Előny](#előny)
7. [Hátrány](#hátrány)

## Általában

Az éllistás reprezentációk két-három részből állnak:
- A csúcsok száma
- Tartalmazzák **az élek felsorolását**
- A csúcsokhoz tartalmazó további információkat

A csúcsok számát azért fontos megadni, mert az magas sorszámú izolált csúcsok nem fognak kiderülni az élek listájából. (Az alacsonyak kiderülnek, mert megígértük, hogy sorban zajlik a sorszámozás, tehát ha nincs 3-as számú csúcs, de egy 4-es sorszámú csúcs össze van kötve valamivel, akkor a 3-as számú csúcs izolált kell legyen. De ha az éleknél a legmagasabb sorszámú csúcs a 6-os, akkor nem tudunk semmit arról, hogy létezik-e 10-es csúcs (ami viszont ha van, biztosan izolált.))

Például a [levelezős](../../#példa-irányítatlan-gráfra) példában, azaz kép szerint ebben a példában:

![Levelezésről készült irányított gráf](../../levelezes.jpg)

- 5 csúcs van
- 8 darab él van, mégpedig a következők: 
```
0 -> 1
1 -> 2
1 -> 3
2 -> 4
2 -> 3
3 -> 2
4 -> 2
4 -> 0
```
- A csúcsok további információkat hordoznak. An i sorszámú csúcs az tömb i-edik elemét jelenti: 
```
Laci
Móni
Eszti
Sanyi
Cecília
```

## MESTER
A Mesteren természetesen minden a lehető legjobban össze van tömörítve. A beolvasás miatt fontos ott megadni az élek számát is. 
```
5 
8
0 1
1 2
1 3
2 4
2 3
3 2
4 2
4 0
Laci
Móni
Eszti
Sanyi
Cecília
```

## Graphviz
Megjegyezzük, hogy az átláthatósága miatt a népszerű gráfrajzoló nyelv, a [graphviz](https://dreampuf.github.io/GraphvizOnline/) is az éllistás reprezentációt használja. Néhány kép, például a [színezéses](../../README.md#példa-színezésre-hurokélre-izolált-csúcsra-többszörös-élre) vagy a [súlyozott gráfos](../../README.md#példa-súlyozott-gráfra) példa linkként funkcionál ilyen gráfreprezentációkra. 

## Matematikai definíció
A fentihez hasonló gráfok egy éllistás stílusú matematikai reprezentációja valahogy így nézne ki:

Egy gráf alatt a $(N, E, T)$ rendezett hármast értjük, ahol
- $N\in \mathbb N$ a csúcsok száma
- $E\subseteq N\times N$ az éllista
- $T \in \textup{Szöveg}^N$

A fenti példában példában:
- $N = 9$
- $E = \{(0,1),(1,2),(1,3),(2,4),(2,3),(3,2),(4,2),(4,0)\}$
- $T = \textup{("Laci", "Móni", "Eszti", "Sanyi", "Cecília")}$


## Változatok:
- Az irányított és irányítatlan gráfok reprezentációja ugyanaz lesz. Ezeknek a használata fog eltérni akkor, amikor dolgozunk velük. 
- Súlyozott gráfok esetén a súlyokat az élek mellé szokás írni a mesteres feladatoknál. A matematikai formulaizmust úgy lehetne módosítani, hogy $E\subseteq N \times N \times \mathbb R$
- a többszörös éleket különböző színű éleket úgy lehet kezelni, hogy több $E_1, E_2, \dots$ halmazt adunk meg az élek halmazának. Mesteren úgy lehet ezt szépen megoldani, hogy az élek száma helyett számok tömbjét adjuk meg. Ha például a tömb úgy kezdődik, hogy ``6 10 ... `` Ilyenkor az élhalmaz első 6 eleme az első szín, a következő 10 elem a második szín stb. 

## Előny

- Az élhalmazos reprezentáció nagyon egyszerűen kezelhető, a gráfelméleti problémák jelentős része egyszerű programozási tételekkel kezelhető feladattá válik. 
- A reprezentáció mérete (memória) és gráfokon futó algoritmusok futási idejei nem függenek a csúcsok számától, csak az élek számától. Ennek megfelelően a kis élszámú gráfok jól, nagyon élszámú gráfok rosszabbul kezelhetők vele.
## Hátrány 
Minden keresési feladat legalább lineáris időt igényel majd. 
A két legfontosabb feladat:
- az élvizsgálat, azaz annak eldöntése, hogy két megadott csúcs között vezet-e él. Ez egy lineáris keresési feladat (eldöntés programozási tétel), ami **lineáris idejű**.
- a szomszédgyűjtés, azaz egy csúcs szomszédos csúcsainak kiválogatása(kiválogatás programozási tétel), ami szintén **lineáris idejű**.

A következő két gráfreprezentáció abban lesz más, hogy e két feladatra specializálják magukat. A szomszédsági mátrix az élvizsgálatot dönti el konstans idő alatt, a szomszédsági listás reprezentáció pedig a szomszédgyújtést. 
