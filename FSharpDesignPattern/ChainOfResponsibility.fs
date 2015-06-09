module ChainOfResponsibility

// Chain of responsibility pattern
type Record = {
    Name : string
    Age : int
    Weight : float
    Height : float
}

let chainOfResponsibility() = 
    let validAge record =
        record.Age < 65 && record.Age >18
    let validWeight record =
        record.Weight < 200.
    let validHeight record =
        record.Height > 120.
        
    let check f (record, result) =
        if not result then record, false
        else record, f(record)

    let chainOfResponsibility = check validAge >> check validWeight >> check validHeight

    let john = { Name = "John"; Age = 80; Weight = 180.; Height = 180. }
    let dan = { Name = "Dan"; Age = 20; Weight = 160.; Height = 190. }

    printfn "John's result = %b" (chainOfResponsibility(john, true) |> snd)
    printfn "Dan's result = %b" (chainOfResponsibility(john, true) |> snd)


// Chain of reponsibility sample using pipelining
let chainTemplate processFunction canContinue s =
    if canContinue s then
        processFunction s
    else s

let canContinueF _ = true
let processF x = x + 1

let chainFunction = chainTemplate processF canContinueF

let s = 1 |> chainFunction |> chainFunction

printfn "%A" s