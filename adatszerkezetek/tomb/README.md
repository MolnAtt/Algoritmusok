# Tömb (statikus tömb)

Általános jellemzők
- fix méret, amelyet a tömb létrehozásakor kell megadni, többet ezen változtatni nem lehet.
- elemek index alapján lekérdezhetők. Ez a lekérdezés konstans (1) idő alatt történik. 
- elemek index alapján módosíthatók. Ez a lekérdezés konstans idő alatt történik.
- Lekérdezhető a tömb mérete. Ez a lékérdezés konstans idő alatt történik. 

# C\#
További jellemzők C\#-ban:
- A tömb elemeinek kezdőértéke mindig az adott típus alapértelmezett értéke. Tehát string-tömbök üres stringek, számtömbök 0-ák, objektumtömbök Null-ok. 
- Mivel a C\# nyelv erősen típusos nyelv, minden tömböt csak azonos típusú elemek alkothatnak.

## Változódeklarációk
A tövábbiakban a ``T`` egy tetszőleges típust jelöl. 
```cs
T[] tomb;
int[] szamtomb;
string[] stringtomb;
int[][] szammatrix; // szamtablazat mint szamtombok tombje. 
                    // Angolul "jagged array".
```

## Inicializálás
C#-ban új tömböt a ``new`` paranccsal lehet létrehozni. A létrehozáskor kell megadni az új tömb méretét is! Ezek mindegyike most egy 10 elemű tömb lesz
```cs
T[] tomb = new T[10];
int[] szamtomb = new int[10];
string[] stringtomb = new string[10];
int[][] szammatrix = new int[][10]; // Fontos, hogy ilyenkor 10 elemű lesz a tömb, 
                                    // aminek viszont egyetlen elemében sincs még tömb!
```
## Tulajdonságok
### Hossz
A tömb hossza a ``Length`` tulajdonságon keresztül férhető hozzá:
```cs
int[] t = new int[3];   // t = [0, 0, 0]
int hossz = t.Length;   // hossz = 3
```
## Ciklusok

### Számlálóciklus
Ebben a példában számlálóciklussal kiírjuk egy számtömb összes elemét: 
```cs
int[] t = new int[3];   // t = [0, 0, 0]
for (int i = 0; i < t.Length; i++)
{
    Console.WriteLine(t[i]);
}
```

### Iteráció
Ebben a példában szintén kiírjuk az összes elemét:
```cs
foreach (int elem in t)
{
    Console.WriteLine(elem);
}
```
Az iteráció könnyebben olvasható, átlátható kódot eredményez, azonban nem olyan széleskörűen használható, mint a számlálóciklus. Pl.: számoljuk meg, hányszor van egy tömbben két nulla egymás mellett? Ezt nagyon körülményes iterációval megoldani, számlálóciklussal viszont nagyon egyszerű.

## Másolás

### Referencia alapján
C\#-ban a tömbök esetében a referencia alapú másolás az alapértelmezett. 
Ez azt jelenti, hogy **ha az eredeti tömbben megváltoztatsz egy elemet, akkor az "új" tömbnek is megváltozik az eleme**, mert az tulajdonképpen ugyanaz a tömb, csak másik néven.

```cs
    int[] tomb;
    int[] ugyanaz_a_tomb_masik_valtozoban = tomb;
```

### Érték alapján
Ha egy meglévő tömböt le akarsz másolni, akkor azt bár lehetséges megtenni egy sorban C\#-ban (ez a ``Clone()`` metódus), de ez a megoldás sajnos nem elemi eszközöket használ, sekély másolást használ, amit viszont nehéz módosítani, ha mély másolást akarunk. 

A következő függvény is egy "shallow copy"-s megoldás, de ebben lehet látni, hogy mit kell átírni, hogy az adott szituációban deep copy legyen: 
```cs
static T[] Sekely_masolat<T>(T[] t)
{
    T[] result = new T[t.Length];
    for (int i = 0; i < t.Length; i++)
    {
        result[i] = t[i];   // az "=" miatt ez most egy "shallow copy"!
                            // Ezt kell átírni, ha pl. mátrixot vagy objektumtömböt másolunk!
    }
    return result;
}
```
