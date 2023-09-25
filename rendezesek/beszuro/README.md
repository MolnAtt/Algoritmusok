# Minimumkiválasztásos rendezés


## Ötlet

**Észrevétel:** Egy rendezett listában egy adott értéknél kisebb elemek együtt, egy blokkban helyezkednek el, és ennek a blokknak a legjobboldalibb eleme a legnagyobb, az értéknél még kisebb elem. Ha a szóban forgó értéket el kellene helyeznünk a listában, akkor pontosan ez után az elem után (a nála kisebbek legnagyobbja után) kell **áthelyeznünk**.

Vegyük a második elemet: ha kisebb, mint az első, akkor cseréljük ki vele!
Így a tömb első két eleme már egy rendezett részlistát alkot. 

Vegyük a tömb harmadik elemét! Ha keressük meg az első olyan elemet tőle balra a tömb elejétől, amelyik nagyobb nála. Mivel a tömb tőle balra már rendezett, az első megtalált nála kisebb elem egyben a legnagyobb nála kisebb elem is lesz: tehát ez után **beszúrva** őt a tömb rendezett része eggyel nagyobb lesz. 

Folytatjuk ezt addig, amíg az utolsó elemet el nem érjük.

Videó:

<iframe width="560" height="315" src="https://www.youtube.com/embed/EdIKIf9mHk0?si=jmkqOBzfVXPuq9ZK" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>

Megjegyzés: A videóban nem beszúrás történik, hanem a párok a helyükre folyamatos cserék során jutnak el. A folytonos cserék folytonos (felesleges) értékadásokkal járnak az ideiglenes változók miatt. 
Egyébként, ha a tömbünk valójában egy láncolt lista, akkor az áthelyezés egy konstans idejű műveletté válik, és akkor a kereső-beszúró verzió sokkal gyorsabb lesz, mint a helyére süllyesztő.

## Algoritmus
A könnyebb olvashatóság érdekében három függvényre bontjuk:

```
Eljárás Rendez(t: Tömb):
    Ciklus i:=2-től t.Hossz-ig:
        Áthelyez(t, i, Helye_eddig(t, t[i], i))
    Ciklus vége
Eljárás vége.
```

```
Függvény Helye_eddig(t: Tömb, elem, i:Egész): Egész
    Helye_eddig := 1
    Ciklus amíg Helye_eddig < eddig és t[Helye_eddig] < elem:
        Helye_eddig := Helye_eddig + 1
    Ciklus vége
Függvény vége.
```

```
Eljárás Áthelyez(t: Tömb, innen:Egész, ide, Egész):
    Lokális: 
        temp: Egész
    temp = t[innen]
    Ciklus i:=innentől ide-ig -1-esével:
        t[i] := t[i-1]
    Ciklus vége
    t[ide] := t[temp]
Eljárás vége.
```

### C#
Általános típussal és rendezési szemponttal:
```cs

static void Beszuro_Rendezes_Igazi<T>(List<T> t, Func<T, T, int> r)
{
    for (int i = 1; i < t.Count; i++)
    {
        Áthelyez(t, i, Helye_eddig(t, t[i], i, r));
    }
}

static int Helye_eddig<T>(List<T> t, T elem, int eddig, Func<T, T, int> r)
{
    int j = 0;
    while (j < eddig && r(t[j], elem) < 1)
    {
        j++;
    }
    return j;
}

static void Áthelyez<T>(List<T> t, int innen, int ide)
{
    T temp = t[innen];
    for (int i = innen; ide < i; i--)
    {
        t[i] = t[i - 1];
    }
    t[ide] = temp;
}
```



A videóban ábrázolt algoritmus számokkal azok szokásos rendezése szerint:

```cs

static void Beszuro_Rendezes(List<int> t)
{
    for (int i = 1; i < t.Count; i++)
    {
        Balra_sullyeszt(t, i);
    }
}

static void Balra_sullyeszt(List<int> t, int i)
{
    while (0<i && t[i - 1] > t[i])
    {
        Csere(t, i, i - 1);
        i--;
    }
}
```