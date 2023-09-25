# Minimumkiválasztásos rendezés


## Ötlet
A listában megkeressük a legkisebb elemet. Ezt kicseréljük a lista 1. elemével. 

Ha ez megvan, a lista **hátralevő részében**, azaz a 2. elemtől kezdődő listarészben megkeressük a legkisebb elemet és ezt becseréljük a 2. elemmel

Ha ez megvan, a lista **hátralevő részében**, azaz a 3. elemtől kezdődő listarészben megkeressük a legkisebb elemet és ezt becseréljük a 3. elemmel

és így tovább az utolsó előtti elemig (hiszen utolsó elemnek úgyis a legnagyobb elem fog maradni.)

Videó:

<iframe width="560" height="315" src="https://www.youtube.com/embed/0-W8OEwLebQ?si=OTHH9XBF0VPqTYoc" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>

## Algoritmus
A könnyebb olvashatóság érdekében két függvényre bontjuk:

```
Eljárás Rendez(t: Tömb)
    Ciklus i:=1-től t.Hossz-1-ig:
        Csere(t, i, Min_innen(t, i))
    Ciklus vége
Eljárás vége.
```

```
Függvény Min_innen(t: Tömb, i:Egész): Egész
    Min_innen := i
    Ciklus j:=i+1-től t.Hossz-ig:
        Ha t[j] < t[Min_innen]:
            Min_innen := j
        Elágazás vége
    Ciklus vége
Függvény vége.
```

### C#

Általános típussal és rendezési szemponttal:
```cs
static void Rendezes<T>(List<T> t, Func<T,T,int> r)
{
    for (int i = 0; i < t.Count-1; i++) 
    {
        Csere(t, i, Min_innen(t, i, r));
    }
}
```

```cs
static int Min_innen<T>(List<T> t, int i, Func<T,T,int> r)
{
    for (int j = i + 1; j < t.Count; j++)
    {
        if (r(t[i], t[i]) == -1)
        {
            i = j;
        }
    }
    return i;
}
```




