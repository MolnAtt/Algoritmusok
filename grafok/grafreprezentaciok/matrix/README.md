# Csúcsmátrixos gráfreprezentáció
1. [Általában](#általában)
3. [MESTER](#mester)
5. [Matematikai definíció](#matematikai-definíció)
6. [Előny](#előny)
7. [Hátrány](#hátrány)

# Általában
A szomszédsági mátrixra épülő reprezentációk egyetlen négyzetes mátrixból állnak és a csúcsokhoz tartozó kiegészíő információkból állnak. A mátrixban annyi sor és oszlop van, ahány csúcs, és az i-edik sor j-edik oszlopában az i-edik csúcsból a j-edik csúcsba menő él súlya/megléte szerepel. 

Ha nem súlyozott a gráf, akkor ez egy logikai értékű vagy kétértékű mátrix.

Ha irányítatlan a gráf, akkor ez egy szimmetrikus mátrix.
## MESTER

Mesteren meg kell adni a csúcsok számát, hogy tudjuk, hány sort kell a konzolról beolvasni, de ez máshol nem szükséges.

*(Hogy jól jelenjen meg a tabulátoros megjelenítés, nem km-ben, hanem 100méterben adtuk meg a távolságokat.)*

```
11
0	61	62	0	51	0	0	0	0	0	0	
61	0	0	0	0	61	0	99	65	0	0	
62	0	0	46	0	0	65	0	0	0	0	
0	0	46	0	60	0	85	0	0	0	0	
51	0	0	60	0	0	0	0	0	0	0	
0	61	0	0	0	0	0	103	69	0	0	
0	0	65	85	0	0	0	53	0	0	69	
0	99	0	0	0	103	53	0	0	0	0	
0	65	0	0	0	69	0	0	0	25	0	
0	0	0	0	0	0	0	0	25	0	0	
0	0	0	0	0	0	69	0	0	0	0	
Ősagárd
Nőtincs
Felsőpetény
Alsópetény
Keszeg
Szendehely
Bánk
Rétság
Berkenye
Nógrád
Romhány
```

## Matematikai definíció
A példában szereplő feladatokra a következőképpen lehetne matematikai definíciót adni: 

Gráfnak nevezzük azon $(M, T)$ rendezett párokat, ahol
- $M\subseteq \mathbb R^{N\times N}$, ahol $N\in \mathbb N$ a csúcsok száma
- $T \in \textup{Szöveg}^N$

## Előny
- Szomszédsági listában tárolva a gráf szerkezetét az élvizsgálat jelentősen leegyszerűsödik. Az $i$-edik csúcsból pontosan akkor vezet él a $j$-edik csúcsba, ha a $M_{i,j}\neq 0$. Ez konstans időt jelent. 
- Súlyozott gráfok nagyon természetesen reprezentálhatók mátrixon. 
- Új élek felvétele nem növeli a memóriahasználatot. Az új csúcsok felvétele viszont négyzetesen növeli a memóriahasználatot. Tehát a mátrixos reprezentáció a "sűrű" gráfokban memóriahatékony, ahol kevés csúcs van sok éllel. 

## Hátrány
- A szomszédgyűjtési feladat sajnos itt is lineáris idejű: Az $i$-edik csúcs szomszédai a $i$-edik sor 0-tól különböző oszlopainak sorszámai. Ez egy kiválogatás programozási tétel az $i$-edik soron: kiválogatjuk a nemnulla elemeket, ami lineáris időbe telik.
- Szimmetrikus mátrixok esetén minden élt feleslegesen kétszer tárolunk, tehát kétszerannyi memóriát használunk, mint amennyi szükséges lenne. Ez megoldható, ha csak a mátrix felső háromszögét tároljuk egy megfelelő adatszerkezetben, és az alsó háromszögre való hivatkozásokat átfordítjuk a felső háromszögbe. 
- A mátrix mérete a csúcsok számával négyzetesen nő. Míg az éllistás reprezentációban az izolált csúcsok hozzávételei nem növelték a gráf méretét, a mátrixos reprezentációban ezek négyzetesen emelik a memóriahasználatot. 
