// Faça uma função que recebe uma lista e retorna o produto dos valores primos (utilizar a função da questão 3).

//// Start: Funcao is_primo
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
//// End: Funcao is_primo

let rec produto_dos_num_primos lista = 
    match lista with
    | [] -> 1 // Lista vazia
    | head :: tail when (is_primo head) = true -> // Eh numero primo
        head * produto_dos_num_primos tail
    | _ :: tail -> produto_dos_num_primos tail // Nao eh numero primo

printfn "Resultado do produto dos numeros primos [0-11]: %i" (produto_dos_num_primos [0..11])
printfn "Resultado do produto dos numeros primos [0-5]: %i" (produto_dos_num_primos [0..5])
printfn "Resultado do produto dos numeros primos [0-100]: %i" (produto_dos_num_primos [0..100])