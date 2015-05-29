module File9

// Using an object expression to organize code and invode a C# function

module MyFunctionLibrary =
    let myFunction() = ()

let myData = 
    let myData = ref 9
    {
        new ForFSharpInvoking.IMyInterface with 
            member this.MyFunction () = MyFunctionLibrary.myFunction()
            member this.MyProperty
                with get() = !myData
                and set(v) = myData := v
    }

let myClass = ForFSharpInvoking.MyClass()
myClass.MyFunction(myData)

[<AllowNullLiteralAttribute>]
type NullableType() =
    member this.TestNullable(condition) =
        if condition then NullableType()
        else null

type A() =
    [<DefaultValueAttribute>]
    val mutable MyFunction : unit -> int
    member this.IsMyFunctionInitialized
        with get() = box this.MyFunction = null