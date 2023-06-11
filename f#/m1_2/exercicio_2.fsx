// Faça uma função que receba 3 valores e escreva que tipo de triângulo eles formam:
//  a) Não forma um triângulo - Uma das medidas é maior que a soma das outras duas
//  b) Equilátero - Todos os lados iguais
//  c) Isósceles - Dois lados iguais
//  d) Escaleno - Todos os lados diferentes

let tipo_triangulo lado_1 lado_2 lado_3 =
    let soma_lados = lado_1 + lado_2 + lado_3

    if lado_1 >= soma_lados || lado_2 >= soma_lados || lado_3 >= soma_lados then
        printfn "Nao forma um triangulo"
    elif lado_1 = lado_2 && lado_2 = lado_3 then
        printfn "Triangulo Equilatero"
    elif lado_1 = lado_2 || lado_1 = lado_3 || lado_2 = lado_3 then
        printfn "Triangulo Isosceles"
    else    
        printfn "Triangulo Escaleno"

tipo_triangulo 5 5 5 // Triângulo Equilátero todos lados iguais
tipo_triangulo 5 5 6 // Triângulo Isósceles um lado tem que ser difrente dos demais
tipo_triangulo 3 4 5 // Triângulo Escaleno todos lados sao diferentes
tipo_triangulo 1 2 4 // Não forma um triângulo