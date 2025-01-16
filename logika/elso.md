# Logika - mire eemlékszünk? 

## Igazságtáblázatok -- erre nem lesz szükség most

Mi kijelentéslogika -- nulladrendű logikai nyelv?


$ A ::= p  
\quad | \quad \lnot A  
\quad | \quad A\land B  
\quad | \quad A\lor B
\quad | \quad A\to B
\quad | \quad A\leftrightarrow B
$

Például:

- $p$: Esik az eső
- $q$: Elmegyek boltba
- $r$: Veszek paradicsomlevet
- $t$: Beragadok a liftbe

$\lnot p \to (q \land r)$

$\lnot (\lnot t \land \lnot p)  \leftrightarrow r$

# Szemantika: jelentéstan -- formálisan

minden kijelentés vagy igaz, vagy hamis, de a kettő egyszerre nem. 

Ez alapján készültek az igazságtáblázatok. 

## Predikátumlogika -- Elsőrendű logika 

### Példa: Családi viszonyok

- $No(x)$: az $x$ nő.
- $xGy$: $x$ gyermeke $y$
- $xHy$: $x$ és $y$ házasok


$ \forall x \forall y (xHy \to yHx )$: Minden $x$-re és minden $y$-ra igaz, hogy ha $x$ házastársa $y$-nak, akkor $y$ is házastársa $x$-nek. 

$ \forall x \forall y (xGy \to yGx )$: Bármely két emberre igaz, hogy ha az egyik gyereke a másiknak, akkor ez fordítva is igaz ------- ez valójában nincs így persze...


$xLy$: $x$-nek a lánya $y$ -- de ezt ki lehet fejezni a meglévő fogalmainkkal/jeleinkkel/RELÁCIÓINKKAL
$xLy \iff xGy \land No(y)$
<!-- $ xHy \leftrightarrow yHx $ -->


Vannak háromargumentumú relációk is egyébként a világban...:
$B(x,y,z)$: az $y$ pont az $x$ és $z$ között van.

- $xFy$: $x$-nek a fia $y$

    $ xFy \iff xGy \land \lnot No(y)$
- $xUy$: $x$-nek az unokája az $y$. 

    $ xUy \iff \exists z (xGz \land zGy)$

néhány apróság a $\exists$ jellel kapcsolatban:
- ez mit jelent?
    
    $ \lnot \exists x \lnot No(x)$: nincs olyan ember, aki nem nő lenne
    Ez ugyanaz, mint:
    $ \forall x No(x) $: mindenki nő.

    $\lnot \forall x \lnot No(x)$: Nem mindenkire igaz, hogy nem nő.

    $\exists x No(x)$

    $\lnot \exists x A \iff \forall x \lnot A$

    $\lnot \forall x A \iff \exists x \lnot A$

    Ezeket a jeleket KVANTOR-nak hívják.
    - $\exists$ egzisztenciális kvantor,
    - $\forall$ univerzális kvantor


- $xFTy$: $x$-nek testvére vagy féltestvére az $y$. 

    $ xFTy \iff x\neq y  \land \exists z (zGx \land zGy)$


- $xTy$: $x$-nek édestestvére $y$. 

    $ xTy$:  $x\neq y \land \exists z_1 \exists z_2 ( z_1\neq z_2 \land z_1Gx\land z_1Gy\land z_2Gx \land z_2Gy )$

- $xSy$: $x$ sógora $y$. 

    $xSy\iff \exists z (zHx \land zFTy) \lor \exists z (zFTx \land zHy) $


