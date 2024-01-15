# Adatszerkezetek vegyes feladatgyűjtemény

## Tárolótípusok
A tárolók és műveleteik
- Verem: 
    - Peek():Egész 
        Megnézi a verem legfelső elemét. 
    - Push(x:Egész) 
        Belerak a verembe egy új elemet.
    - Pull():Egész 
        Kiveszi a verem utoljára belerakott elemét.
    - Empty:Logikai
        Megmondja, hogy üres-e verem.
- Sor:
    - Peek():Egész 
        Megnézi a sor legelső elemét. 
    - Push(x:Egész) 
        Belerak a sorba egy új elemet.
    - Pull():Egész 
        Kiveszi a sorból a legrégebben benne lévő elemet.
    - Empty:Logikai
        Megmondja, hogy üres-e sor.
- Kupac: 
    - Peek():Egész 
        Megnézi a kupac legkisebb elemét.
    - Push(x:Egész) 
        Belerak a kupacba egy elemet.
    - Pull():Egész 
        Kiveszi a kupacból a legkisebb elemet.
    - Empty:Logikai
        Megmondja, hogy üres-e kupac.
- Láncolt lista Elem:
    Megadja a lista első elemét. Minden Elem típusnak két vagy három tulajdonsága van: 
    - Jobb():Elem
        Az elem jobb oldali szomszédja a listában
    - Tartalom():Egész
        A elem tényleges tartalma
    - Bal():Elem
        Az elem bal oldali szomszédja, amennyiben oda-vissza láncolt listáról van szó. 
- Halmaz: 
    - Add(x:Egész)
        Belerak a halmazba egy elemet
    - Remove(x:Egész)
        Kivesz a halmazból egy elemet
    - Count:
        Megmondja a halmaz számosságát
    -  

## Feladattípusok:
- [COUNT:P] Hány P tulajdonságú elem van a tárolóban?
- [WHERE:P] Válogasd ki a P tulajdonságú elemeket a tárolóból!
- [SUM] Add össze a tároló elemeit!
- [WHERE:P + SUM] Add össze a tároló P tulajdonságú elemeit!
- [PROD] Szorozd össze a tároló elemeit! 
- [CONTAINS] Van-e P tulajdonságú elem a tárolóban?
- [FIRST] Add vissza az első P tulajdonságú elemet!
- [LAST] Add vissza az utolsó P tulajdonságú elemet!
- [FIRSTINDEX] Add meg, hogy hanyadik az első P tulajdonságú elem!
- [LASTINDEX] Add meg, hogy hanyadik az első P tulajdonságú elem!
- [COPY] Másold le a tárolót!
- [REVERSE] Add meg a tárolóbeli elemeket a tárolóban lévő sorrendjükkel ellentétes sorrendben!
- [ORDER_BY] Add mega tárolóbeli elemeket az R reláció szerint sorba rendezve
- [UNION] Megadja két tároló unióját
- [INTERSECTION] Megadja két tároló metszetét
- [MINUS] Megadja a két tároló különbségét
- [DIFFERENCE] Megadja a két tároló megkülönböztető elemeit

Mindegyik feladat úgy értendő, hogy 
- A vizsgált tárolók szerkezete változhat a vizsgálat során abban az értelemben, hogy a vizsgálat előtt és után ugyanúgy kell kinézzen a vizsgált tároló. Ebből az is következik, hogy 
- A tároló eredményű feladatoknál új halmazt kell készíteni és az visszaadni

## Feladatok:
A sor jelentése: Feladattípus, tárolótípus, használható memória, sebességkorlát. Feltesszük, hogy a tároló N elemű. ‹N jelenti azt, hogy bizonyos feladatok hamarabb is megszakíthatók (pl. Contains)
1. [COUNT: P] Verem vagy Kupac: N+1, N 
2. [COUNT: P] Sor: 1, N 
3. [COUNT: P] Láncolt lista, 1, N
4. [WHERE: P] Verem vagy kupac: 2N, 2N
5. [WHERE: P] Sor: N, 2N
6. [WHERE: P] Láncolt lista: N, N
 