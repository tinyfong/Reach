module File14

// Pattern-matching sample
let isEvenNumber x = x % 2 = 0
let transformEvenToZero x =
    match isEvenNumber x with
    | true -> 0
    | false -> x
let r = seq {0..100} |> Seq.sumBy transformEvenToZero

// Using the functiion keyword
let functionSample =
    function
        | 1 -> printfn "this is one"
        | _ -> printfn "other value"

// Tuple pattern
let orFunction(x, y) =
    match x, y with
        | true, true -> true
        | true, false -> true

let orFunction2(x, y) =
    match x, y with
        | false, false -> false
        | _, _ -> true
