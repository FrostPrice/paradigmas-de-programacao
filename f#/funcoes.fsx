// printf "Informe um numero: "
// let input_int = System.Console.ReadLine() |> System.Int32.Parse
let input_int = 1

let verificar_par numero = numero % 2 = 0
let escreve_par numero = 
    printf "O numero %i eh par" numero
let escreve_impar numero =
    printf "O numero %i eh impar" numero

// Funcao Aninhada
let escreve_par_impar numero =
    if verificar_par numero then
        escreve_par numero
    else 
        escreve_impar numero

escreve_par_impar input_int
printf "\n"

let numero_par_ate_10 = [0..10] |> List.filter verificar_par

// [<EntryPoint>]
// let main argv =
//     for num in numero_par_ate_10 do
//         printfn "%i" num
//     0

let dobra_menores_5() = 
    let multiplica_2 numero = numero * 2
    let menor_que_5 numero = numero < 5

    let lista = [0..10]
    let lista_filtrada = List.filter menor_que_5 lista
    let result = List.map multiplica_2 lista_filtrada
    result

printfn "Sem Pipeline: %A" (dobra_menores_5())

let pipe_dobra_menores_5 =
    let multiplica_2 numero = numero * 2
    let menor_que_5 numero = numero < 5

    [0..10] |> List.filter menor_que_5 |> List.map multiplica_2

printfn "Pipeline: %A" pipe_dobra_menores_5

let soma_2 = (+) 2
let multiplica_5 = (*) 5

let operacoes numero_1 numero_2 =
    numero_1 + numero_2
    |> soma_2
    |> multiplica_5

printfn "%A" (operacoes 5 2)

// Exercicio 1
let pares_menor_que_5  (array)= 
    let menor_que_5 numero = numero < 5
    let par numero = numero % 2 = 0

    array |> List.filter menor_que_5 |> List.filter par

printfn "Exercicio 1: %A" (pares_menor_que_5([0..10]))

// Exercicio 2
// let multiplica_por = (*)
// let multiplica_por_10 = multiplica_por 
// let soma = (+)
// let soma_5 = soma 5
// let soma_10 = soma 10

// let calculos numero =
//     let r1 = soma_2 numero
//     let r2 = multiplica_por_10 r1
//     let r3 = soma_5 r2
//     r3

let calculos numero =
    let multiplica_por = (*)
    let multiplica_por_10 = multiplica_por 10
    let soma = (+)
    let soma_5 = soma 5
    let soma_2 = soma 2

    numero |> soma_2 |> multiplica_por_10 |> soma_5 


printfn "Exercicio 2: %A" (calculos 5)