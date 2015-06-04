module File15

// Using try...with...finally to handle an exception

open System

let exceptionCatch() = 
    try
        try
            let a = 3 / 0
            printfn "%d" a
        with
        | :? DivideByZeroException -> printfn "divided by zero"
    finally
        printfn "finally sectin executing..."

exceptionCatch()


// The failwith and failwithf examples
try
    failwith "this is an exception"
with :? Exception as e -> printfn "the exception msg is %s" e.Message

try
    failwithf "this is an exception generated at %A" DateTime.Now
with _ as e -> printfn "the exception msg is %s" e.Message


// The raise exception
try
    raise (Exception("raise exception"))
with _ -> printfn "catch exception"

try
    try
        raise(Exception("raise exception"))
    with _ -> printfn "catch exception"; reraise()
with _ -> printfn "catch reraise exception"


// The nullArg, invalidArg, and invalidOp functions
let demoInvalidArgumentAndOperation arg0 arg1 =
    if arg0 = null then
        nullArg "arg0 is null"
    if arg1 = System.String.Empty then
        invalidArg "arg1" "arg1 is empty string"
    invalidOp "sorry, this is an invalid operatioin"