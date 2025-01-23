# Tarski-féle elemi geometria

A bácsi: Alfred Tarski

## nyelve:
$ \varphi ::= B(x,y,z) \quad | \quad E(x,y,z,t) \quad | \quad \lnot \varphi \quad | \quad \varphi \land \psi
\quad | \quad 
\varphi \lor \psi
\quad | \quad \varphi \to \psi \quad | \quad \varphi \leftrightarrow \psi$

$B(x,y,z)$ jelentése: Az y pont az $x$ és $z$ pontok között van

$E(x,y,z,t)$: Az xy szakasz és a zt szakasz ugyanakkora ("ekvidisztáns"/equidistant)

# Feladatok
1. Fogalmazd meg, hogy egy F pont az AB szakasz felezőpontja!

$F_{AB} = F \iff B(A,F,B) \land E(A,F,F,B)$

$H_{\underline{A}B} = H \iff \exists H' (B(A,H,B) \land B(A,H',B) \land E(A, H, H, H') \land E(H,H',H',B))$

súlyvonal: csúcspont és a szemben lévő oldal felezőpontját összekötő szakasz

ABC egy háromszög:
$ \Delta(A,B,C)\iff   \lnot B(A,B,C) \land \lnot B(B,A,C) \land \lnot B(B,C,A) $

AX szakasz az ABC háromszög súlyvonala:
$ \Delta(A,B,C) \land X = F_{BC} $

ABC háromszög egyenlő szárú és az alapja BC:
$ \Delta(A,B,C) \land E(A,C, A,B) $