# Algoritmusok jegyzet

## Listák programozási tételei

### Elemi feladatok
Az elemi listakezelési feladatok problémamegoldás szempontjából két fő csoportra bonthatók:

- Amikor végig kell nézni a listát: 
    - Összesítések (reduce)
        - [Megszamolas](elemi_programozasi_tetelek/megszamolas/) (count)
        - [Összegzés](elemi_programozasi_tetelek/osszegzes/) (sum)
        - [Maximumkeresés](elemi_programozasi_tetelek/maximumkereses/) (max)
    - [Másolás](elemi_programozasi_tetelek/masolas/) (map, select)
    - [Kiválogatás](elemi_programozasi_tetelek/kivalogatas/) (filter, where)
    - [Csoportosítás](elemi_programozasi_tetelek/csoportositas/) (group by)
- És amikor nem: 
    - [Kiválasztás](elemi_programozasi_tetelek/kivalasztas/)
    - [Keresés](elemi_programozasi_tetelek/kereses/)
    - [Eldöntés](elemi_programozasi_tetelek/kereses/) 

### Rendezetlen halmazok programozási tételei
- Ismétlődések eltávolítása (unique)
- Elemvizsgálat -> Eldöntés
- Részhalmazvizsgálat -> Eldöntés
- Unió
- Metszet
- Különbség
<!-- - Szimmetrikus differencia -->

## Rendezések és keverések: 

### Rendezések
A rendezések sebesség szempontjából két fő csoportra bonthatók:

- Lassú rendezések: egy $n$ elemű $n^2$ idő alatt rendeznek.
    - Maximumkiválasztásos rendezés (selection sort)
    - Buborékos rendezés (bubble sort)
    - Beszúró rendezés (insertion sort)
    - Héjrendezés (shell sort)
- Gyorsabb rendezések: egy $n$ elemű tömböt $n\cdot \log_2 n$ idő alatt rendeznek. 
    - Gyorsrendezés (quick sort)
    - Összefésüléses rendezés (merge sort)
    - Kupac-rendezés (heap sort)

### Keverések
- Fisher-Yates-keverés (Fisher-Yates shuffle)

### Mohó algoritmusok

## Rendezett listák programozási tételei
- Logaritmikus keresés (binary search)
- Rendezett halmazok elemvizsgálata
- Rendezett halmazok részhalmazvizsgálata
- Rendezett halmazok uniója (összefésülés, merge)
- Rendezett halmazok metszete
- Rendezett halmazok különbsége

## Kiválasztási függvények programozási tételei 
- Visszalépéses eldöntés
- Visszalépéses keresés
- Visszalépéses kiválogatás
- Visszalépéses maximumkiválasztás

## Dinamikus programozás
- Dinamikus programozás 

## Mátrixok
- Összesítések (reduce)
    - Megszamolas
    - Összegzés
    - Maximumkeresés
- Másolás
- Kiválogatás
- Kiválasztás
- Keresés
- Eldöntés

## Gráfalgoritmusok
- Szélességi bejárás
- Mélységi bejárás
- Legrövidebb út
- Dijkstra-algoritmus
- Floyd-Warshall-algoritmus