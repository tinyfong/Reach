module File5 

    type File(fileName:string) = class
        let myField = 0
        member this.MyFunction() = myField
        member this.FileName with get() = fileName
        end

    type File with 
        member this.GetFileName = this.FileName


    let inline (-?) (x: int) (y: int) = x - 3*y
    printf "%d" (10 -? 1)

    let inline (!++) (seq:int seq) = seq |> Seq.sum
    let result = !++ [1..4]


    let f a b = a + b

    type MyDelegateType = delegate of int * int -> int
    let delegateValue = new MyDelegateType(f)

    let fResult = f 1 2
    let fromDeletegate = delegateValue.Invoke(1,2)


    type IntDeleagate = delegate of int -> unit
    type MyType = 
        static member Apply (i:int, d:IntDeleagate) =
            d.Invoke(i)
    MyType.Apply(0, (fun x -> printfn "%d" x))


    type PrintDelegate = delegate of string -> unit

    let printOne = PrintDelegate(fun s -> printfn "One %s" s)
    let printTwo = PrintDelegate(fun s -> printfn "Two %s" s)

    let printBoth = PrintDelegate.Combine(printOne, printTwo)

    let printResult = printBoth.DynamicInvoke("aaa")


    type Delegate = delegate of obj * System.EventArgs -> unit

    type MyClassWithEvent() = class
        let myEvent =new Event<_>()
        [<CLIEventAttribute>]
        member this.Event = myEvent.Publish
        member this.RaiseEvent(args) = myEvent.Trigger(this, args)
        end

    let classWithEvent = new MyClassWithEvent()
    classWithEvent.Event.Add(fun (e) -> printfn "message is %A" e)
    classWithEvent.RaiseEvent("Hello")