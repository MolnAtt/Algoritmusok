# Rendezések

## Típusfeladat
- Rakjuk növekvő sorrendbe a számokat!
- Rakjuk abc-sorrendbe a karakterláncokat!
- Rakjuk a megadott rendezés szerint csökkenő/növekvő sorrendbe a megadott elemeket!

## Általánosságban
A típusoknak általában van egy alapértelmezett rendezése (számoknál a szokásos $\leq$, karakterláncoknál az alfabetikus rendezés). Amennyiben ilyen alapértelmezett rendezés nincs, akkor vagy adni kell a típusnak ilyen alapértelmezett rendezést (ICompare, C#) vagy egy rendezési szempontra (comparator) van szükségünk. Ezek általában kétbemenetű logikai (C++) vagy egész-értékű (C# vagy Python) függvények vagy $\lambda$-kifejezések. 

Egész értékű $R$ rendezési szempontok általában úgy értendők, hogy három értékkel bírnak: 
$$ \mathrm{R}(a,b)  \overset{def}{=}\left\{\begin{array}{ll}
-1,& \textup{ha }a \textup{ kisebb, mint }b,
\\0,& \textup{ha }a \textup{ és }b \textup{ rendezés szempontjából megkülönböztethetetlen,}
\\1,& \textup{ha }a \textup{ nagyobb, mint. }b\end{array}
\right. $$

## Specifikáció

A specifikáció során relációnak tekintjük a rendezést, nem pedig egész értékű függvénynek.

**Előfeltétel**
Feltesszük, hogy 

- $(\forall{a\in H}) \ a\leq a $
<!-- - $(\forall{a,b\in H}) \ ((a\leq b \land b\leq a) \to a = b )$ -->
- $(\forall{a,b\in H}) \ (a\leq b \lor b\leq a)$
- $(\forall{a,b,c\in H}) \ ((a\leq b \land b\leq c) \to a \leq c )$

ahol $H\overset{def}{=} \{t[i]: i\in [0..\mathbf N_t]\}$. 


$$\textup{Rendezett}(t) \overset{def}\iff (\forall i,j \in [1..\mathbf N_t]) (i\leq j \to t[i]\leq t[j]) $$

Megjegyezzük, hogy itt a $\leq$ kétféle értelemben van: Egyrészt az egész számok közötti szokásos rendezés értelmében, másrészt pedig a tömbelemek közti fenti feltételeket kielégítő rendezés értelmében. 

Mivel a rendezéstől nem vártuk el az antiszimmetriát, azaz hogy 
$$(\forall{a,b\in H}) \ ((a\leq b \land b\leq a) \to a = b )$$
így egy halmazt többféleképpen is rendezetté lehet tenni. Ha pl. a rendezés a karakterláncokat a hosszuk szerint rakja sorba, akkor az azonos hosszú karakterláncok egymáshogy viszonyított sorrendje nem egyértelmű, tehát "a sorozat rendezett verziója"-fogalom sem egyértelmű. 

### Észrevételek:
- Az üres és az egyelemű tömbök mindig definíció szerint rendezettek.

## Algoritmusok

A legtöbb rendezés része a listán belüli csere: 

```
Eljárás Csere(t: Tömb, i:Egész, j:Egész)
    Lokális:
        temp
    temp := t[i]
    t[i] := t[j]
    t[j] := temp
Eljárás vége.
```
Amennyiben két paraméterrel hívjuk meg, akkor a két változó értékét cseréljük meg

```
Eljárás Csere(a,b)
    Lokális:
        temp
    temp := a
    a := b
    b := temp
Eljárás vége.
```
Ez utóbbit jelöljük néha így is: 

```
(a,b) := (b,a)
```

A rendezési algoritmusok sebesség szempontjából két fő csoportra bonthatók:

- [Logaritmikus keresés](logaritmikus_kereses): Egy $n$ elemű rendezett kömbben megkeresünk egy $P$ tulajdonságú elemet.
- [Lassú rendezések](lassu_rendezesek): egy $n$ elemű tömböt $n^2$ idő alatt rendeznek.
    - [Minimumkiválasztásos rendezés](minimum/) (selection sort)
    - [Buborékos rendezés](buborek/) (bubble sort)
    - [Beszúró rendezés](beszuro/) (insertion sort)
    - Héjrendezés (shell sort)
- Gyorsabb rendezések: egy $n$ elemű tömböt $n\cdot \log_2 n$ idő alatt rendeznek. 
    - [Gyorsrendezés](gyors/) (quick sort)
    - [Összefésüléses rendezés](osszefesuleses/) (merge sort)
    - [Kupac-rendezés](kupac/) (heap sort)



# Keverések
## Típusfeladat
- Rakjuk véletlenszerűen sorba a számokat!
- Keverjük össze a lista elemeit!
- **Visszatevés nélküli mintavétel**: Válassz véletlenszerűen $k$ elemet az $n$ elem közül úgy, hogy a kihúzott elemeket nem rakod vissza a listába! 

## Általánosságban
Fontos, hogy a keveréseket általában úgy értjük, hogy a tömb bármely eleme azonos valószínűséggel fordulhasson elő a tömb bármely helyén a keverés után! Ha pl. a második elemtől kezdve minden pozíciót véletlenszerűen (50%-50%) megcserélünk az előző elemmel, akkor igaz lesz az, hogy az elemek bárhova kerülhetnek, de az már nem igaz, hogy az első elem ugyanakkora valószínűséggel keveredik a tömb végére, mint a tömb második helyére (egy 10 elemű tömbnél az utóbbinak $\frac 14$, az előbbinek $\frac 1{512}$ a valószínűsége)



## Specifikáció

Jelölje $k$ a $t$ tömb megkevert állapotát. 
- Létezzen egy bijekció a $t$ és $k$ elemei között, hogy a párbaállított elemek egyenlők. 
- A tömb bármely elemének pozíciója a kevert tömbben (fenti bijekció szerint) azonos valószínűséggel lehessen bármelyik index. 

(formulae is under construction...)

Egy lehetséges megoldás a Fisher-Yates vagy Knuth-keverés:
- [Fisher-Yates-keverés](keveresek/Fisher-Yates/) (Fisher-Yates shuffle)