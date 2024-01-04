# Gráfok
## Gráfok nem formálisan

Általában az olyan jelenségeket próbáljuk gráfokként formalizálni, amelyek ábrázolása során **csomópontokat** (**csúcsokat**) rajzolunk és amelyeket valamilyen módon **összekötünk**. Az összeköttetéseket általában **éleknek** nevezzük. 

Fontos viszont, hogy a csúcsok helyzete, egymástól való távolsága általában lényegtelen, az összeköttetéseik az egyetlen fontos tulajdonságaik.

### Irányítás
Léteznek irányítatlan gráfok és irányított gráfok. Az irányított gráfoknál nyilakat, az irányítatlan gráfoknál pedig egyszerű vonalakat rajzolunk az ábráinkban: 
#### Példa irányított gráfra
Egy baráti társaság levelezése. A csúcsok az emberek, a nyilak pedig azt mutatják, hogy ki küldött kinek levelet. 

![Levelezésről készült irányított gráf](levelezes.jpg)

*Ha az egyik ember küldött levelet egy másiknak, még nem biztos, hogy ez visszafele is igaz, ezért fontos az irányítás jelzése.*


#### Példa irányítatlan gráfra
Egy bajnokság pillanatnyi állása. A csúcsok a csapatok, az élek pedig az, hogy játszottak-e már egymással. 

![Bajnokságról készült irányítatlan gráf](bajnoksag.jpg)


*Ha az egyik játszott a másikkal, akkor nyilván a másik is játszott az egyikkel, tehát nincs értelme megkülönböztetni a élek irányát...*

## Szabadkozás
A gráfok rendkívül sokfélék lehetnek, alapvetően egy olyan adatszerkezetről van szó, ami a lehető leglazább rendszereket próbálja összefogni. Ennek megfelelően ha formalizálnánk egy olyan gráf-fogalmat, amely az összes gráfnak hívott jelenséget formalizálja, akkor az általánosság és egyetemesség ára egy rendkívül bonyolult és nehezen kezelhető definíció lenne. Ezért **nem adunk általános, mindent lefedő definíciót**. Általában a különböző alkalmazások is mindig nagyon speciális gráfokat igényelnek, csak az nagyon változatos, hogy és a gráf specialitása miben nyilvánul meg. Tehát a gyakorlatban szinte az a helyzet, hogy ahány feladat van, annyiféle gráfdefiníció létezik. Tehát azt mutatjuk meg, hogy a különböző *gyakori* variánsok hogyan formalizálhatók.


## Adatszerkezet/gráfreprezentációk

### Éllista

### Szomszédsági mátrix

### Szomszédsági listák


## Algoritmusok

### Szélességi és mélységi bejárás

```
Függvény El_lehet_e_jutni(graf:Graf, innen:Egész, ide:Egész): Logikai
    Lokális:
        fehér:Egész
        szürke:Egész
        fekete:Egész
        tennivalok: Verem
        szin:Tömb[Egész]
        tennivalo: Egész

    fehér := 0
    szürke := 1
    fekete := 2

    szin := új Tömb[Egész](graf.Csúcsszama)
    tennivalok := új Verem

    tennivalok.Beletesz(innen)
    szin[innen] := szürke

    El_lehet_e_jutni := Hamis

    Ciklus amíg nem El_lehet_e_jutni és nem tennivalók.Üres():
        tennivalo := tennivalok.Kivesz()

        Ha feldolgozando = ide:
            El_lehet_e_jutni := Igaz
            szin[feldolgozando] := fekete
        Egyébként:
            Iteráció szomszéd eleme graf.szomszédai[tennivalo]:
                Ha szín[szomszéd]= fehér:
                    tennivalok.Beletesz(szomszéd)
                    szin[szomszéd] := szürke
                Elágazás vége
            Iteráció vége
        Elágazás vége
    Ciklus vége


Függvény vége.

```

### Legrövidebb út