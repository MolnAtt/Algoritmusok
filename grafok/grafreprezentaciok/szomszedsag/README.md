# Szomszédsági listás gráfreprezentáció
1. [Általában](#általában)
3. [MESTER](#mester)
5. [Matematikai definíció](#matematikai-definíció)
6. [Előny](#előny)
7. [Hátrány](#hátrány)

## Általában

A szomszédsági listák arról szóló beszámolók, hogy egy csúcsnak mely más csúcsok a szomszédai. Tehát ez egy "listában-a-lista"-szerkezet lesz, ahol az $i$-edik lista $j$-edik eleme egy csúcs sorszáma, amely szomszédja $i$-nek. 

Egy csúcslistás vagy szomszédsági listás reprezentációhoz a csúcsokról szóló információn túl egyetlen listában-a-lista szerkezetre van szükség, ahol 
- a tartalmazott listákban mind különböző számok vannak, és 
- mindegyik tartalmazott lista csak kisebb természetes számokat tartalmaz, mint ahány lista van összesen. 


## MESTER
Mivel a mesteren konzolról olvasunk be, tudni kell, hogy hány csúcs (és ebben az esetben hány belső lista) van összesen.

A fenti, levelezős példában ez a következőképpen nézhetne ki egy mesteres feladatban:

```
5 
1
2 3
3 4
2
2 0
Laci
Móni
Eszti
Sanyi
Cecília
```
Tehát a lényeg az, hogy az 5-ös számot követő $i$i-edik sorban azon csúcsok sorszámai állnak, amelyek szomszédai az $i$-edik csúcsnak. 

## Matematikai definíció
Ez alapján egy szomszédsági listájával megadott gráf alatt olyan rendezett $(S, T)$ párt értünk, ahol 
- $ X \in S \iff X \subseteq {[}1..N{]}$, ahol $N$ a csúcsok száma, azaz az $S$ halmaz számossága
- $T$ pedig egy $N$ elemű tömb

## Előny
- A bejárások során a szomszéd csúcsok megállapítása nagyon fontos lépés, ez itt konstans idejű művelet, ezért a bejárásközpontú feladatoknál ezt szoktuk használni.

## Hátrány
- A Van-e-él feladat megállapítása lassabb, mint a csúcsmátrixos reprezentációnál, mert a szomszédlistákon lineáris keresést kell végrehajtani -- igaz, csak egy csúcs szomszédai között kell keresni.