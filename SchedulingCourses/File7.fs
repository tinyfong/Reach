module File7

// Use mutable-variable data storage in the object expression
type IA =
    abstract member F : int with get, set

let objectExpression =
    let dataStorage = ref 9
    {
        new IA with
            member this.F
                with get() = !dataStorage
                and set(v) = dataStorage := v
    }


// Implementing an object expression interface
type IMyInterface =
    abstract F : unit -> unit

type IMyInterface2 =
    abstract F2 : unit -> unit

let objExpression = 
    {
        new IMyInterface with
            member this.F() = printfn "hello object expression"
    }

let objExpression2 =
    {
        new IMyInterface with
            member this.F() = printfn "from interface"
        interface IMyInterface2 with
            member this.F2() = printfn "from interface2"
    }


