# Peano-aritmetika: Természetes számok elemi elmélete

# nyelve: 

## terminus -- az, amit be lehet írni egy relációba
$ \tau ::= x 
\quad | \quad 0 
\quad | \quad s(x) 
\quad | \quad x+y 
\quad | \quad x\cdot y $

s(x): "x rákövetkezője"

$ \varphi ::= x=y 
\quad |\quad \lnot \varphi
\quad |\quad  \varphi \land \psi
\quad |\quad  \varphi \lor \psi
\quad |\quad  \varphi \to \psi
\quad |\quad  \varphi \leftrightarrow \psi
\quad |\quad \exists x \varphi
\quad |\quad  \forall x \varphi
$


$s(0) = 1$

$s(s(0)) = 2 = ss0$

$4 = ssss0$

I. axióma: A nulla semminek sem a rákövetkezője

$ \lnot \exists x \, s(x) = 0 $

II. axióma: Ha két szám rákövetkezője ugyanaz, akkor a két szám is ugyanaz.

$ \forall x, y (s(x) = s(y) \to x=y) $

másik megfogalmazás: különbözők rákövetkezője különböző

III. axióma: Bármely számhoz nullát adva semmi nem történik:

$ \forall  x \quad x+0 = x$

IV. axióma: 

$ \forall  x \quad x+s(y) = s(x+y)$


