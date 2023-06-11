let HelloWorld() = printf "Hello World\n"

let valor = 2

let numeroPar numero = 
    if numero % 2 = 0 then 
        printf "2"
    else
        printf "1"

let testePar numero = 
    if numero % 2 = 0 then 
        true
    else
        false

// HelloWorld()
// printfn "Hello World from F#"
// numeroPar(19)
printfn "%A - %A" (testePar 5) (testePar 6)