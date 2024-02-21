# Lista (dinamikus lista)

Általános jellemzők
- rugalmas méret. 
- a lista eleinte 0 méretű, 
- az új elemeket hozzá lehet adni.
- elemeket lehet kivenni is belőle.
- elemek index alapján lekérdezhetők. Ez a lekérdezés konstans (1) idő alatt történik. 
- elemek index alapján módosíthatók. Ez a lekérdezés konstans idő alatt történik.
- Lekérdezhető a lista (változni képes)mérete. Ez a lékérdezés konstans idő alatt történik. 


# C\#
További jellemzők C\#-ban:
- Mivel a C\# nyelv erősen típusos nyelv, minden listát csak azonos típusú elemek alkothatnak.

## Változódeklarációk
A tövábbiakban a ``T`` egy tetszőleges típust jelöl. 
```cs
List<T> lista;
List<int> szamlista;
List<string> stringlista;
List<List<int>> szammatrix;     // szamtablazat mint számlisták listája.
List<int[]> szammatrix2;         // szamtablazat mint számtömbök listája.
```

## Inicializálás
### Üres listák
C#-ban új listát a ``new`` paranccsal lehet létrehozni.
```cs
List<T> lista = new List<T>();
List<int> szamlista = new List<int>();
List<string> stringlista = new List<string>();
List<List<int>> szammatrix = new List<List<int>>();
List<int[]> szammatrix2 = new List<int[]>();
```
### listák megadott elemekkel
Ez a parancs egy listát hoz létre az 1,2, 3 elemekkel. 
```cs
List<int> l = new List<int>{1, 2, 3}; // l = [1, 2, 3]
```

### Adott méretű listák

Capacity!

## Tulajdonságok
### Hossz
A lista hossza a ``Count`` tulajdonságon keresztül férhető hozzá:

```cs
List<int> l = new List<int>;   // l = []
int hossz = l.Count;   // hossz = 0
```

## Ciklusok
### Számlálóciklus
Ebben a példában számlálóciklussal kiírjuk egy számlista összes elemét: 
```cs
List<int> l = new List<int>();   // t = [0, 0, 0]
for (int i = 0; i < l.Count; i++)
{
    Console.WriteLine(l[i]);
}
```

### Iteráció
Ebben a példában szintén kiírjuk az összes elemét:
```cs
foreach (int elem in l)
{
    Console.WriteLine(elem);
}
```
Az iteráció könnyebben olvasható, átlátható kódot eredményez, azonban nem olyan széleskörűen használható, mint a számlálóciklus. Pl.: számoljuk meg, hányszor van egy listaben két nulla egymás mellett? Ezt nagyon körülményes iterációval megoldani, számlálóciklussal viszont nagyon egyszerű.
## Másolás

### Referencia alapján
C\#-ban a listák esetében a referencia alapú másolás az alapértelmezett. 
Ez azt jelenti, hogy **ha az eredeti listaben megváltoztatsz egy elemet, akkor az "új" listanek is megváltozik az eleme**, mert az tulajdonképpen ugyanaz a lista, csak másik néven.

```cs
    int[] lista;
    int[] ugyanaz_a_lista_masik_valtozoban = lista;
```

### Érték alapján

underconstruction