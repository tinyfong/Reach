module File8

// Object expression with a property
type IMyInterface =
    abstract F : unit -> unit
    abstract Prop0 : string with get, set
    abstract Prop1 : string with get, set

let myData = ref ""


let objExpression = 
    let x = ref ""
    {
        new IMyInterface with
            member this.F() = printfn "hello object expression"
            member this.Prop0 with get() = !x and set(v) = x:=v
            member this.Prop1 with get() = !myData and set(v) = myData:=v
    }

objExpression.Prop0 <- "set Prop0"
printfn "%s" objExpression.Prop0

objExpression.Prop1 <- "set Prop1"
printfn "%s" objExpression.Prop1


// Ojbect expression based on class
type IMyInterface2 =
    abstract F2 : unit -> unit

[<AbstractClassAttribute>]
type MyAbstractClass() =
    abstract F : unit -> unit
    member this.F2() = printfn "my abstract class"

let objExpressionInterFaceAbstract =
    {
        new MyAbstractClass() with
            override this.F() = printfn "implement the abstract class"
        interface IMyInterface2 with
            member this.F2() = printfn "from interface2"
    }

let objExpressionExtendObject =
    {
        new System.Object() with
            override this.ToString() = "hello from object expression"
    }
