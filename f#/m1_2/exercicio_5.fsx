// Faça uma função em que o usuário digite 3 números e calcule a média entre elas, outra
// função que retorna se a média é acima ou abaixo da média e uma terceira, que a partir da
// informação booleana de aprovado ou reprovado, escreve uma mensagem correspondente
// ao resultado na tela. Essas funções devem estar aninhadas dentro de uma função
// resultado_notas que deve chamar as 3 funções internas utilizando pipeline.

let resultado_notas () =
    let input_usuario_nota (numero: int) =
        printf "Digite a nota %d: " numero
        System.Console.ReadLine() |> float

    let media_notas (nota_1: float) (nota_2: float) (nota_3: float) =
        (nota_1 + nota_2 + nota_3) / 3.0
    
    let acima_ou_abaixo (media: float) =
        if media >= 7.0 then
            true
        else
            false
    
    let mensagem (aprovado: bool) =
        if aprovado then
            "Aprovado"
        else
            "Reprovado"

    let resultado =   
        (input_usuario_nota 1, input_usuario_nota 2, input_usuario_nota 3)
        |||> media_notas
        |> acima_ou_abaixo
        |> mensagem

    printfn "Esse aluno esta %s" resultado 

resultado_notas()