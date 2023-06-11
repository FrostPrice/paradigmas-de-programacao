// Faça uma função que receba 2 valores, caso sejam iguais, multiplique os dois, caso sejam diferentes, faça o primeiro valor elevado ao segundo. Não pode utilizar o operador 3 de potência (deve ser feita uma sequência de multiplicações, 2^3 = 2 * 2 * 2).

let rec calcular num_1 num_2 =
    match num_1, num_2 with
    | num_1, num_2 when num_1 = num_2 -> num_1 * num_2 // Se iguais, apenas multiplicas os dois
    | num_1, num_2 -> // Se diferentes, faz a potencia usando uma sequência de multiplicações, x^y
        let rec potencia x_base y_expoente =
            match x_base with
            | 0 -> y_expoente
            | _ -> potencia (x_base - 1) (y_expoente * num_1)
        potencia num_2 1

printfn "Resultado: %i" (calcular 3 3)
printfn "Resultado: %i" (calcular 5 3)
printfn "Resultado: %i" (calcular 3 5)