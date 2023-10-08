# Gyorsrendezés (Quicksort)

## Ötlet

**Észrevétel:** Egy elemet addig igazítgatunk, amíg tőle jobbra a nála nagyobb, tőle balra pedig a nála kisebb elemek nem lesznek. Ha ez teljesül, akkor az elem a **helyére** kerül. Ha az így kialakuló két féllistára újra meghívjuk ezt az algoritmust, akkor a rendezés problémáját kisebb listákra vezettük vissza. Előbb-utóbb egyelemű listákat kell majd rendezni, ahol a rendezés triviális, így készen van a rekurzió. 

Videó:

<iframe width="560" height="315" src="https://www.youtube.com/embed/3San3uKKHgg?si=s1PFm7RJc__4SIx6" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>

## Algoritmus
A könnyebb olvashatóság érdekében két függvényre bontjuk:




```
Függvény Helyére_mozgat(t: Tömb, i:Egész, j:Egész):Egész
    Ciklus amíg nem i=j:
        Ha vagy i<j vagy lista[i], lista[j]:     { kizáró vagy! }
            Csere(lista[i], lista[j])
            Csere(i, j)
        Elágazás vége
        Ha i < j:
            j := j-1
        egyébként 
            j := j+1
    Helyére_mozgat = i;
Függvény vége.
```

```
Eljárás Rendez(t: Tömb)
    Rendez(t, 0, t.Hossz)
Eljárás vége.
```

```
Eljárás Rendez(t: Tömb, e:Egész, v: Egész)
    Lokális:
        hely: Egész
    Ha e < v:
        hely := Helyére_mozgat(t, e, v)
        Rendez(t, e, hely-1)
        Rendez(t, hely+1, v)
    Elágazás vége.
Eljárás vége.
```


### C#
Általános típussal és rendezési szemponttal:
```cs

static void QuickSort<T>(List<T> lista, Func<T, T, int> r)
{
    QuickSort<T>(List<T> lista, r, 0, lista.Count)
}

static void QuickSort<T>(List<T> lista, Func<T, T, int> r, int e, int v)
{
    if ( e < v )
    {
        int hely = Helyere_tesz(lista, r, e, v);
    }
    QuickSort(lista, r, e, hely - 1);
    QuickSort(lista, r, hely + 1, v);
}

static int Helyere_tesz(List<T> lista, Func<T, T, int> r, int i, int j)
{
    while (i != j)
    {
        if ( (i<=j) != (r(lista[i], lista[j])) < 1) 
        {
            (lista[i], lista[j]) = (lista[j], lista[i]);
            (i, j) = (j, i);
        }
        j += i.CompareTo(j);
    }
    return i;
}
```