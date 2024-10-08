# Adatszerkezet/gráfreprezentációk

## Miért nem adunk teljesen általános definíciót
A gráfok rendkívül sokfélék lehetnek, alapvetően egy olyan adatszerkezetről van szó, ami a lehető leglazább rendszereket próbálja összefogni. Ennek megfelelően ha formalizálnánk egy olyan gráf-fogalmat, amely az összes gráfnak hívott jelenséget formalizálja, akkor az általánosság és egyetemesség ára egy rendkívül bonyolult és nehezen kezelhető definíció lenne. Ezért **nem adunk általános, mindent lefedő definíciót**. Általában a különböző alkalmazások is mindig nagyon speciális gráfokat igényelnek, csak az nagyon változatos, hogy és a gráf specialitása miben nyilvánul meg. Tehát a gyakorlatban szinte az a helyzet, hogy ahány feladat van, annyiféle gráfdefiníció létezik. A továbbiakban azt mutatjuk meg, hogy a különböző *gyakori* variánsok hogyan formalizálhatók.

### Jelölési egyszerűsítések
A továbbiakban nagy mértékben leegyszerűsíti a definíciókat, ha **a csúcsok csak 0-ával kezdődő, sorban egymás után következő természetes számok lehetnek.** Ezzel semmilyen részletet nem veszítünk igazából: A fenti levelezős példában azt a további információt, hogy a sorszámok kiket is jelölnek, a nevek egy tömbjében el is tárolhatjuk. A csúcs sorszáma mindig megmondja majd, hogy melyik névről van szó. Hasonlóképpen, a gráfok reprezentációja során sosem kell bajlódnunk azzal, hogy a csúcsok esetleg összetettebbek, mint a sima számok -- ha így lenne, akkor egy tömbben eltároljuk a további információkat, amiket a számok ismeretében konstans idő alatt mindig le lehet majd hívni, amikor szükségünk van ezekre.  

Tehát a reprezentációk mindig abban fognak leginkább különbözni, hogy az éleket, az összeköttetéseket hogyan rögzítik.


A csúcsok sorszámozással való kódolása egyetlen szempontból nem hasznos: Ha a feladatok során a gráfok csúcsokat veszítenek vagy új csúcsokat nyernek. Ilyenkor változik az egész számozás és bonyolult korrigációkat igényel az adatszerkezet. A feladatok között azonban csak nagyon kevés olyan van, ahol nem csak az élek halmaza, de a csúcsok halmaza is változásnak van kitéve.


## Főbb gráfreprezentációk:
- [Éllista](ellista/): A gráf itt nem más, mint az élek egy listája és egy beszámoló az élek által nem érintett csúcsokról (azaz az izolált csúcsokról). A gráfokra vonatkozó feladatok megoldásai ebben a formában nem mások, mint (él)listákon alkalmazott programozási tételek.
- csúcs[mátrix](matrix/): A gráf itt nem más, mint a csúcsok sorszámaiból alkotott mátrix. 
- [Szomszédság](szomszedsag/)i lista: Ez egy listában-a-lista adatszerkezet arról, hogy mely csúcsnak mely csúcsok a szomszédai.

