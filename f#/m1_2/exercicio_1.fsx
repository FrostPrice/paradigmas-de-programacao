// Faça uma função que receba 2 valores e retorne a divisão do maior pelo menor.

let maior num_1 num_2 = 
    if num_1 >= num_2 then
        num_1
    else 
        num_2

let menor num_1 num_2 =
   if num_1 <= num_2 then
        num_1
    else 
        num_2  

let divide_maior_pelo_menor valor1 valor2 =
    let maior = maior valor1 valor2
    let menor = menor valor1 valor2
    maior / menor

let resultado = divide_maior_pelo_menor 20 5
printfn "Resultado: %d" resultado  