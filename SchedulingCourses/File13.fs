module File13

// Compare a record, tuple and DU
type MyRecord = { X: int; Y: string }

type MyTuple = int * string 

type MyDU =
    | Case1 of int
    | Case2 of string
    | Case3 of MyRecord
    | Case4 of MyTuple


let inline compare x y =
    if x > y then
        printfn "%A > %A" x y
    elif x = y then
        printfn "%A = %A" x y
    else
        printfn "%A < %A" x y

let record1 = { X = 1; Y = "1" }
let record2 = { X = 1; Y = "2" }

compare record1 record2

let tuple1 : MyTuple = 1, "1"
let tuple2 : MyTuple = 1, "2"

let du1 = Case1(1)
let du2 = Case1(2)

compare du1 du2

