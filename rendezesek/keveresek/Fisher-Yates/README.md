# Minimumkiválasztásos rendezés


## Ötlet
A listából kiválasztunk egy random elemet. Ezt kicseréljük a lista 1. elemével. 

Ha ez megvan, a lista **hátralevő részéből**, azaz a 2. elemtől kezdődő listarészből kiválasztunk egy random elemet és ezt becseréljük a 2. elemmel

és így tovább az utolsó előtti elemig.

## Algoritmus

```
Eljárás Kever(t: Tömb)
    Ciklus i:=1-től t.Hossz-1-ig:
        Csere(t, i, Random(i, t.Hossz))
    Ciklus vége
Eljárás vége.
```

### C#

Általános típussal és rendezési szemponttal:
```cs
static Random r = new Random();

static void Rendezes<T>(List<T> t)
{
    for (int i = 0; i < t.Count-1; i++) 
    {
        Csere(t, i, r.Next(i. t.Count-1));
    }
}
```




