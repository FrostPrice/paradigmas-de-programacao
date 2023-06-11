// (1, 2)
// ("one", "two", "three")
// ("string", 1, 5, 6)


let print_tupla tupla =
    match tupla with
    | (a, b) -> printfn "Par %A %A" a b 

print_tupla (1, 2)

let (a, b) = (1, 2)
let (a_2, _) = (1, 2)

let c = fst (1, 2) // Pega o primeiro item da tupla
let d = snd (1, 2) // Pega o segundo item da tupla

printfn "A & B: %A %A" a b
printfn "A_2: %A" a_2
printfn "C: %A" c
printfn "D: %A" d

let terceiro (_, _, c) = c
printfn "Valor a partir da tupla: %A" terceiro

let coordenada = (50, 69)

let escreveCoordenada coordenada = 
    match coordenada with
    | (x, y) -> printfn "X: %i, Y: %i" x y

escreveCoordenada coordenada

// As tuplas fornecem uma maneira conveniente de retornar vários valores de uma função, como pode ser utilizado para a criação do próximo passo do fibonacci por pipeline

let proximo_fibonacci valor = 
    match valor with
    | (a, b) ->  (b, a + b)

let sexto_fibonacci = (0, 1) |> proximo_fibonacci |> proximo_fibonacci |> proximo_fibonacci |> proximo_fibonacci |> proximo_fibonacci |> proximo_fibonacci 

printfn "Sexto Fibonacci: %A" (snd sexto_fibonacci)

// Funcao Parcial
let soma a b = a + b
let soma_5 = soma 5
printfn "Soma 5: %i" (soma_5 4)

// Tupla priobe funcao parcial
let soma_tupla valores = 
    match valores with  
    | (a, b) -> a + b