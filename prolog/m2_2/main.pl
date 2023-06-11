/* ### Base de conhecimento */
progenitor(maria, jose).
progenitor(joao, jose).
progenitor(joao, ana).
progenitor(jose, julia).
progenitor(jose, iris).
progenitor(iris, jorge).
masculino(joao).
masculino(jose).
masculino(jorge).
feminino(maria).
feminino(julia).
feminino(ana).
feminino(iris).

/* ### Regras */
/* # 1. Pode-se definir o predicado filho/2 como sendo o inverso de progenitor/2: se X é progenitor de Y, então Y é filho de X. Escreva uma regra para computar o predicado filho/2 e teste com algumas consultas. */
filho(X, Y) :- progenitor(Y, X).

/* # 2. Escreva regras para os predicados mãe/2 e pai/2. Teste sua regra. */
mae(X, Y) :- progenitor(X, Y), feminino(X).
pai(X, Y) :- progenitor(X, Y), masculino(X).

/* # 3. Escreva regras para os predicados avô/2 e avó/2. Teste sua regra. */
avo(X, Y) :- progenitor(X, Z), progenitor(Z, Y), masculino(X).
avo(X, Y) :- progenitor(X, Z), progenitor(Z, Y), feminino(X).

/* # 4. Escreva uma regra para o predicado irmã/2. Teste sua regra. Em particular, teste com a consulta irmã(X, iris). */
irma(X, Y) :- progenitor(Z, X), progenitor(Z, Y), feminino(X), X \= Y.