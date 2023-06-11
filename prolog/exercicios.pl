# Considere que o predicado progenitor(A, B) significa que A é progenitor (i.e., pai ou mae) de B
# Fatos
progenitor(maria, jose).
progenitor(joao, jose).
progenitor(joao, ana).
progenitor(jose, julia).
progenitor(jose, iris).
progenitor(iris, jorge).

# Desenhe a árvore genealógica representada pela base de conhecimento.
# joao
#   |-> ana
#   |-> jose

# maria
#   |-> jose

# jose
#   |-> julia
#   |-> iris

# iris
#   |-> jorge

# Escreva uma consulta para responder à seguinte pergunta: “Ana é progenitora de Jorge?”
progenitor(ana, jorge)

# Escreva uma consulta para retornar os progenitores de Íris.
progenitor(X, iris)

# Escreva uma consulta para retornar os progenitores de José.
progenitor(X, jose)

# Escreva uma consulta para retornar todos os pares progenitor/filho da base de conhecimento.
progenitor(X, Y)

# Escreva uma consulta para retornar todos os avós de Jorge. Dica: sua consulta será formada por dois termos separados por vírgula.
progenitor(X, jorge) , progenitor(Y, X)

# Escreva uma consulta para retornar todos os netos de João.
progenitor(joao, X) , progenitor(X, Y)

# Escreva uma consulta para retornar todos os progenitores comuns de José e Ana.
progenitor(X, ana) , progenitor(X, jose)