# Specifikációhoz matematikai definíciók
Azt hiszem, ezt csak a magam szórakoztatására csináltam. 

## Két szám közötti természetes számok halmaza
$$ i \in [n..m] \overset{\mathrm{def}}{\iff} n\leq i \land i\leq m$$

Ha nem tesszük fel, hogy $i$ csak természetes szám lehet, azaz a halmazelmélet nyelvét használjuk, akkor 

$$ {[}n..m{]}  \overset{\mathrm{def}}{=} [n,m] \cap \mathbb N$$ ahol ${[}n,m{]}$ a szokásos intervallumjelölés.

# Tömbök elsőrendű elmélete

## Logikai alapok

### Nyelv:
Három szortú nyelvet használunk. 
1. A listák/tömbök szortja. 
2. A természetes számok szortja, amely a természetes számok szokásos elsőrendű nyelvét (A Peano-Aritmetika nyelvét) követi.
3. Az értékek szortja. 
A harmadik szortot "szabadon hagyjuk", nem teszünk fel róla szortspecifikus axiómákat, csak akkor, amikor néhány programozási tétel ezt felteszi, például rendezést a maximumkeresésnél vagy egy kétargumentumú műveletet az összegzésnél.


#### Terminusok
##### Változók, Függvény és relációjelek: 
**Változójelek:** A tömbökre a $t, t_1, \dots$, az indexekre az $i, i_1, \dots$ és az értékekre az $e, e_1, \dots$ változójeleket használjuk. 

**Függvényjelek:** Az $\mathbf N$ egyargumentumú szortösszekötő függvényjel egy lista hosszát jelöli majd. Ez tehát tömbterminusokon lesz alkalmazható és az eredménye egy számterminus lesz. Az $\mathbf{N}(t)$ természetes számra mint a *lista hossza* fogunk hivatkozni. Rövidebben általában az $\mathbf N_t$ jelölést fogjuk alkalmazni.

**Relációjelek:** Az elemlekérdezés háromváltozós, szortösszekötő relációja: $\mathbf{[]}(t, i, e)$. Ha e három változó között a reláció fennáll, azt mondjuk majd, hogy a *$t$ tömb $i$-edik helyén $e$ áll*. 

**Számterminusok** alatt a következőképpen előálló terminusokat értjük:
$$ 
    \tau_i ::=      i 
    \quad |\quad    i + j 
    \quad |\quad    i\cdot j
    \quad |\quad    \mathbf N_t 
$$

Feltesszük, hogy a harmadik, szabadon hagyott értékszortnak is megvannak a maga terminusai, ezeket a terminusokat $\tau_e$-vel fogjuk jelölni.

#### Formulák

$$ 
    \varphi ::=     t_1 = t_2
    \quad |\quad    \tau_{i} = \tau_{j}
    \quad |\quad    \tau_{e_1} = \tau_{e_2}
    \quad |\quad    \mathbf{[]}(t, \tau_{i}, \tau_{e})
    \quad |\quad    \lnot \varphi
    \quad |\quad    \varphi \land \psi    
    \quad |\quad    (\exists t) \varphi
    \quad |\quad    (\exists i) \varphi
    \quad |\quad    (\exists e) \varphi
$$

### Axiómák
Az indexek szortjára teljesül a természetes számok elsőrendű elmélete (vagy csak PA).

1. tömbök indexelése a nullától történik és folyamatosan tart a tömb hosszáig 
$$ i \in {[}0..\mathbf N_t-1{]} \leftrightarrow (\exists e) \mathbf{[]}(t, i, e)$$
2. Az elemlekérdezés reláció egy parciális függvény.
$$ t_1=t_2 \land i_1 = i_2 \land \mathbf{[]}(t_1, i_1, e_1) \land \mathbf{[]}(t_2, i_2, e_2)\rightarrow e_1 = e_2$$
3. Extenzionalitás: Ha két ugyanakkora tömbnek ugyanazon pozíciókon ugyanazon elemei szerepelnek, akkor a két lista ugyanaz.
$$ (\mathbf N_{t_1} = \mathbf N _{t_2} \rightarrow (\forall i \in {[}0, \mathbf{N}_{t_1}-1{]}) ((\mathbf{[]}(t_1, i, e)) \leftrightarrow \mathbf{[]}(t_2, i, e)) \rightarrow L_1=L_2)$$
(Az utóbbi axióma jobban olvasható lesz a későbbi jelölések használatával)

### Eleme-jelölés: $e\in L$
**Definíció.** *(eleme)* Azt mondjuk, hogy az *$e$ érték eleme a $t$ tömbnek*, ha valamilyen $i$ indexre teljesül, hogy $\mathbf{[]}(L, i, e)$:

$$e \in L[i] \overset{\mathrm{def}}{\iff} (\exists i) \mathbf{[]}(L, i, e)$$

### Elemlekérdezés jelölése: $L[i]$
**Definíció.** *(lekérdezés)* A második axióma alapján jogosan használhatjuk a következő jelölést:
$$t[i]=e \overset{\mathrm{def}}{\iff} \mathbf{[]}(t, i, e)$$

Az elemlekérdezés kétargumentumú, második argumentumában parciális függvénye, amely egy $t$ tömbhöz és *bizonyos* $i$ természetes számokhoz hozzárendel egy elemet. Erre a hozzárendelt elemre mint az *L lista i-edik eleme* hivatkozunk és $t[i]$-ként jelöljük.

E jelölésben könnyebben olvasható alakban is felírhatók az axiómák:

1. $ i \in {[}0..\mathbf N_{t}-1{]} \leftrightarrow (\exists e) t[i] = e$
2. $ t_1=t_2 \land i_1 = i_2 \land t_1[i_1]= e_1 \land t_2[i_2] = e_2 \rightarrow e_1 = e_2$ (ebben a jelölésben ez ugye triviális)
3. $\mathbf{N}_{t_1} = \mathbf{N}_{t_2} \rightarrow (t_1=t_2 \leftrightarrow (\forall i \in {[}0, \mathbf{N}_{t_1}-1{]}) (t_1[i] = t_2[i] )$

### Korolláriumok
$$ t_1 = t_2 \implies t_1[i] = t_2[i] $$
$$ i = j \implies t[i] = t[j] $$


## Tömbelméleti definíciók
### Elem hozzáadása listához
$$[e|t]=r \overset{\mathrm{def}}{\iff} \mathbf{N}_r = \mathbf{N}_t+1 \land t[\mathbf{N}_t] = e \land (\forall\, i\in [0..\mathbf{N}_t-1]) \, t[i] = r[i]$$

### Tömbök konkatenációja
$$ 
    t_1 + t_2 = t \overset{\mathrm{def}}{\iff} 
    \mathbf{N}_t = \mathbf{N}_{t_1}+\mathbf{N}_{t_2} 
    \land (\forall\, i\in [0..\mathbf{N}_{t_1}-1]) (t[i] = t_1[i])
    \land (\forall\, j\in [0..\mathbf{N}_{t_2}-1]) (t[j+\mathbf{N}_{t_1}] = t_2[j])
$$

### Listák megadása elemfelsorolással
#### üres lista
${[}{]} = t \overset{\mathrm{def}}{\iff}  \lnot (exists i)(exists e) \, t[i]=e$

A fenti axiómákból következik, hogy ${[}{]}$ egyértelmű; hiszen ha lenne kettő üres lista is, akkor ezeknek legalább egy pozición különbözniük kellene. De ennek ellentmond az extenzionalitási axióma. 

#### egyelemű lista
$$[e] = t \overset{\mathrm{def}}{\iff} \mathbf{N}_t = 1 \land t[0] = e$$

#### véges sok elemű lista
Legyen $X$ egy metanyelvi változó, amely véges sok értékszortra utaló konstansszimbólumot tartalmaz vesszővel elválasztva.
$[e, X] = t \overset{\mathrm{def}}{\iff} t = [e|[X]]$

