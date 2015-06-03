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
// Missing one pattern in the pattern-matching expression
let orFunction(x, y) =
    match x, y with
        | true, true -> true
        | true, false -> true
        | false, true -> true
//        | false, false -> true

let orFunction2(x, y) =
    match x, y with
        | false, false -> false
        | _, _ -> true

// Using the tuple pattern to work with the Dictionary.TryGetValue function
let f x =
    let dict =System.Collections.Generic.Dictionary()
    dict.[0] <- "0"
    dict.[1] <- "1"
    match dict.TryGetValue x with
    | true, v -> sprintf "found %A mapped to %A" x v
    | false, _ -> "cannot find"

printfn "%A" (f 0)
printfn "%A" (f 1)
printfn "%A" (f 2)


// An array pattern
let arrayLength array =
    match array with
    | [| |] -> 0
    | [| _ |] -> 1
    | [| _; _ |] -> 2
    | [| _; _; _ |] -> 3
    | _ -> Array.length array

// An example of the conoperator
let rec listLength acc list =
    match list with
    | head :: tail ->
        listLength (acc + 1)  tail
    | [] -> acc

// Pattern matching for list
let list = [1;2;3;4]
match list with
| h0::h1::t -> printfn "two elements %A %A and tail %A" h0 h1 t 
| _ -> ()

let objList = [box(1); box("a"); box('c')]
match objList with
| [:? int as i;
   :? string as str;
   :? char as ch] ->
        printfn "values are %A %A %A" i str ch
| _ -> ()


// NULL pattern
let extractOption x =
    match x with
    | Some a -> printfn "option has value %A" a
    | None -> printfn "option has no value"

let toOption x =
    match x with
    | null -> None
    | _ -> Some x


// Record and identifier patterns
type Shape =
    | Circle of double 
    | Triangle of double * double * double
    | Rectangle of double * double

let getArea shape =
    match shape with
    | Circle(r) -> r * r * System.Math.PI
    | Triangle(a, b, c) ->
        let s = (a + b + c) / 2.
        sqrt s * (s - a) * (s - b) * (s - c)
    | Rectangle(a, b) -> a * b

type Point2D = { x :float; y: float }

let isOnXAxis p =
    match p with
    | { Point2D.x = 0.; Point2D.y = _ } -> true
    | _ -> false

// And/Or pattern used to test a point
let testPoint2 point =
    match point with
    | x, y & 0, 0 -> "original point"
    | x, y & 0, _ -> "on x axis"
    | x, y & _, 0 -> "on y axis"
    | _ -> "other"


// Point relative to line f(x) = x
let testPoint tuple =
    match tuple with
    | x, y when x = y -> "on the line"
    | x, y when x > y -> "below the line"
    | _ -> "up the line"


// Type pattern example
let testType (x:obj) =
    match x with
    | :? float as f -> printfn "float value %f" f
    | :? int as i -> printfn "int value %d" i
    | _ -> printfn "type cannot process"


// Choice example
let a : Choice<int, int> = Choice2Of2 1

let f1 x =
    match x with
        | Choice1Of2 e -> printfn "value is %A" e
        | Choice2Of2 e -> printfn "value is %A" e
f1 a


// Defining a single-case active pattern
let (| Remainder2 |) x = x % 2

let checkNumber x = 
    match x with
        | Remainder2 0 -> "even number"
        | Remainder2 1 -> "odd number"
        | _ -> "other nubmer"


// Using a single-case active pattern as a function
open System.Collections.Generic

let (|SafeDict|) (d : Dictionary<_, _>) =
    if d = null then Dictionary<_, _>()
    else d

let tryFind(SafeDict dic) key =
    if dic.ContainsKey key then
        Some dic.[key]
    else None


// Partial-case active pattern
let (|LessThan10|_|) x = if x < 10 then Some x else None
let (|Btw10And20|_|) x = if x >= 10 && x < 20 then Some x else None

let checkNumber2 x =
    match x with
    | LessThan10 a -> printfn "less than 10, the value is %d" a
    | Btw10And20 a -> printfn "between 10 and 20, the value is %d" a
    | _ -> printfn "that's a big number %d" x


// Multicase active pattern example
let (|FirstQuarter|SecondQuarter|ThirdQuarter|FourthQuarter|) (date: System.DateTime) =
    let month = date.Month
    match month with
    | 1 | 2 | 3 -> FirstQuarter month
    | 4 | 5 | 6 -> SecondQuarter month
    | 7 | 8 | 9 -> ThirdQuarter month
    | _ -> FourthQuarter month

let newYearresolution date =
    match date with
    | FirstQuarter _-> printfn "New Year resolutiion: lose 10 lbs this year!"
    | SecondQuarter _-> printfn "beef is good for summer BBQ"
    | ThirdQuarter _-> printfn "maybe I should diet?"
    | FourthQuarter _-> printfn "Mom's apple pie is wonderful"