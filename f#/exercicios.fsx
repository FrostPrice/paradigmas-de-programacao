// Faça uma função em F# que dado um valor escreve o seu módulo (valor sem sinal)
let absoluto numero =
    if numero < 0 then 
        numero * -1
    else
        numero

// Faça uma função em F# que receba 2 valores e calcule a média aritmética entre eles
let media num1 num2 : float = (num1 + num2) / 2.0
    // let resultado = (num1 + num2) / 2
    // resultado

// Faça uma função que recebe três valores e retorna o menor
let menor num1 num2 num3 = 
    if num1 > num2 && num2 > num3 then
        num3
    else if num1 > num2 then
        num2
    else 
        num1

// Faça uma função que receba 3 números e retorne se eles formam um triângulo equilátero, isósceles ou escaleno
let triangulo num1 num2 num3 =
    if num1 = num2 && num2 = num3 then
        "Equilatero"
    else if num1 = num3 || num1 = num2 || num2 = num3 then
        "Isoceles"
    else 
        "Escaleno"

// Testes //
printfn "%i" (absoluto -1)
printfn "%i" (absoluto -3)

printfn "%f" (media 10.0 9.0)

printfn "%i" (menor 2 3 8)

printfn "%s" (triangulo 1 1 1)
printfn "%s" (triangulo 1 2 1)
printfn "%s" (triangulo 1 2 3)