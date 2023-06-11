// Faça uma função que retorne o próximo elemento da sequência de Fibonacci passando os
// 2 elementos anteriores, depois faça uma função que retorne o sexto elemento da
// sequência. Não utilize comandos de repetição, a função de próximo elemento deve ser
// chamada repetidas vezes utilizando o operador de pipe ( |> ).

let proximo_fibonacci a b : int =
    a + b

// Fibonacci da sexta posicao: 1, 1, 2, 3, 5, 8
let sexto_fibonacci =
    // proximo_fibonacci 1 1 = 2
    // proximo_fibonacci 2 1 = 3
    // proximo_fibonacci 3 2 = 5
    // proximo_fibonacci 5 3 = 8
    // 1 + 1 = 2 |> 2 + 1 = 3 |> 3 + 2 = 5 |> 5 + 3 = 8 (OK) |> 8 + 5 = 13 |> ....     
    proximo_fibonacci 1 1 |> proximo_fibonacci 1 |> proximo_fibonacci 2 |> proximo_fibonacci 3

printfn "Fibonacci de 6 numeros: %A" sexto_fibonacci