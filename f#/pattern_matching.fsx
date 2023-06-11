// let par_ou_impar num =
//     if num % 2 = 0 then 
//         "Par"
//     else    
//         "Impar"
let par_ou_impar num = 
    match num % 2 = 0 with
    | true -> "Par"
    | false -> "Impar"

printfn "%s" (par_ou_impar 1)
printfn "%s" (par_ou_impar 2)

let zero_par_ou_impar num =
    match num with
    | 0 -> "Zero"
    | num when num % 2 = 0 -> "Par"
    | _ -> "Impar"

printfn "\n\n"
printfn "%s" (zero_par_ou_impar 0)
printfn "%s" (zero_par_ou_impar 8908)
printfn "%s" (zero_par_ou_impar 2321)

// Fatorial recursivo com match
let rec fatorial num =
    match num with
    | 1 -> 1
    | _ ->  num * fatorial (num - 1)

printfn "Fatorial recursivo com match: %i" (fatorial 5)

let rec soma_lista lista =
    match lista with
    | head :: tail -> head + soma_lista tail
    | [] -> 0
printfn "Pattern Matching com listas: %i" (soma_lista [1; 1; 2; 3; 5])

////////////////////////////////////////////////////
// Exercicios:

// Faça uma função que recebe um número e retorne se ele é primo ou não. 
let rec is_primo num =
    match num with
    | 1 -> false // 1 não é primo
    | 2 -> true // 2 é primo
    | num when num % 2 = 0 -> false // Números pares maiores que 2 não são primos
    | num ->
        let limite = int(sqrt(double num)) + 1
        let rec verificar_divisores i =
            match i with
            | i when i > limite -> true // Não encontrou divisores até o limite, é primo
            | i when num % i = 0 -> false // Encontrou um divisor e não é primo
            | _ -> verificar_divisores (i + 2) // Verifica o próximo possível divisor ímpar
        verificar_divisores 3
printfn "Eh Primo %b" (is_primo 5)

// Faça em F#, utilizando recursividade e Pattern Matching, um programa que retorne o N-ésimo número da sequência de Fibonacci, lembrando que um termo da sequência é sempre a soma dos dois termos anteriores:
// 1, 1, 2, 3, 5, 8, 13, 21, 34....
let rec fibonacci pos =
    match pos with
    | 1 | 2 -> 1
    | _ -> fibonacci (pos - 2) + fibonacci (pos - 1)

printfn "Fibonacci com Match e Recursividade: %i" (fibonacci 6)    

// Faça uma função que recebe uma lista e retorna a soma dos valores pares.
let rec soma_par lista: int =
    match lista with
    | [] -> 0
    | head :: tail when head % 2 = 0 -> head + soma_par tail
    | _ :: tail -> soma_par tail

printfn "Soma somentes os numeros pares: %i" (soma_par [1; 1; 2; 3; 5; 8; 13])    
printfn "Soma somentes os numeros pares: %i" (soma_par [1..25])    