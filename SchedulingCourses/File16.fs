module File16

// GI function takes one parameter
let inline functionA (x : ^T) = (^T : (member MyMethod : unit -> int) x)

let inline functionB (x : ^T) str =
    (^T : (member CanConnectWithConnectString : string -> int)
        (x, str))

// The inline key word affects the type inference
let F x = float x + 1.
let inline F_inline x = float x + 1.


// The inline keyword
let inline f x = x + 1
type InlineSample() =
    member inline this.F x = x + 1
    static member inline F x = x + 1