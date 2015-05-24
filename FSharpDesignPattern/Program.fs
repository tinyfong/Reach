// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    let test = ChainOfResponsibility.chainOfResponsibility
    
    printfn "OK"
    
    0 // return an integer exit code
