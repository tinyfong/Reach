﻿module Adapter

// 
type Cat() =
    member this.Walk() = printfn "cat walks"

type Dog() =
    member this.Walk() = printfn "dog walks"

let adapterExample() =
    let cat = Cat() 
    let dog = Dog() 

    let inline walk (x : ^T) = (^T : (member Walk : unit -> unit) x)

    walk(cat)
    walk(dog)