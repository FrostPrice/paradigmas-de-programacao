// Faça uma função que recebe uma lista e retorna o produto dos valores ímpares.

let rec produto_impares lista =
    match lista with
    | [] -> 1 // Para uma lista vazia
    | head :: tail when head % 2 <> 0 -> // Para valores impares, multiplica os impares
        head * produto_impares tail
    | _ :: tail -> produto_impares tail // Para valores pares, ignora o numero e continua a recursao

printfn "Resultado do produto dos Impares: %i" (produto_impares [])
printfn "Resultado do produto dos Impares: %i" (produto_impares [1..3])
printfn "Resultado do produto dos Impares: %i" (produto_impares [1..11])