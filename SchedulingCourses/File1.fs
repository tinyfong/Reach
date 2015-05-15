namespace MyClassNamespace

open System.Runtime.InteropServices

type MyClass()=
    member this.PrintValue(?value:int)=
        match value with
            | Some(n)-> printfn"value is %A" n
            | None -> printfn "sorry, no value"

    member this.PrintValue2([<Optional;DefaultParameterValue(0)>]value:int,
                            [<Optional;DefaultParameterValue(null)>]str:string)=
            let defaultStr=if str=null then "null value" else str
            printfn "(%A, %A)" value defaultStr


