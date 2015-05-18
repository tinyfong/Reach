module File3

type Point2D(xValue: double, yValue: double)=class
    static let mutable count = 0
    static do printfn "point2D constructor"
    end

type Screen() =
    let points=System.Collections.Generic.List<Point2D>()
    static do printfn "screen constructor"
    member this.ShowPoint() = printf "inside ShowPoint"

type MyClass() = class
    member val ``else`` = 0 with get, set
end

module TestModule=
    let screen = Screen()
    screen.ShowPoint()
   
module SpecialReservedMemberNameTest =
    let f() =
        let ``else`` = 99
        let ``end`` = 100
        let ``F#`` = 101
        let ``my value`` = 102
        let ``let`` = 103
        ()
        
    let myValue = MyClass()

    printfn "put break point here"

