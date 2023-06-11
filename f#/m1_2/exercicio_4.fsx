// Faça uma função que a partir de um vetor [0..20] e faça o seguinte processo:
//  a) Primeiro filtre os valores para deixar somente pares do vetor (List.filter)
//  b) Depois multiplique cada valor por 2 (List.map)
//  c) Por último filtre novamente os valores, agora para deixar somente os múltiplos de 6
// OBS: As operações devem ser aplicadas utilizando o operador pipe ( |> ).

let filtra_vetor (vetor: int list) =
    let par num = num % 2 = 0

    let multiplica_por = (*)
    let multiplicar_por_2 = multiplica_por 2

    let multiplos_de_6 num = num % 6 = 0

    vetor
    |> List.filter par
    |> List.map multiplicar_por_2
    |> List.filter multiplos_de_6

let vetor = [0..20]
let resultado = filtra_vetor vetor
printfn "Resultado %A" resultado