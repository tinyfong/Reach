module File10

[<Measure>] type cm

[<Measure>] type ml = cm ^ 3

let x = 3.<cm>
let c = x * x * x

// Adding static members to unit-of-measure types

[<Measure>]
type m =
    static member C = 3.28<foot/m>
    static member FromFoot (x:float<foot>) = x / m.C
    static member ToFoot(x:float<m>) = x * m.C
and [<Measure>] foot =
    static member FromMeter = m.ToFoot
    static member ToMeter = m.FromFoot

let r1 = m.FromFoot(3.28<foot>)

// A generic function using a unit of measure

[<Measure>] type lb
[<Measure>] type inch

let add (x : float<'u>) (y : float<'u>) = x + y * 2.

let result1 = add 4.<lb> 3.<lb>
let result2 = add 1.<inch> 2.<inch>

printfn "result1 = %A, result2 = %A" result1 result2

// Converting a number to and from a unit of measure
let removeUnit<[<Measure>] 'u> x = float x

let result = removeUnit 4.<lb>

let fourlb : float<lb> = LanguagePrimitives.FloatWithMeasure result

// Bank account using a unit of measure
type AccountState =
    | Overdrawn
    | Silver
    | Gold

[<Measure>] type USD
[<Measure>] type CND

type Account<[<Measure>] 'u>() =
    let mutable balance = 0.0<_>
    member this.State
        with get() =
            match balance with
            | _ when balance <= 0.0<_> -> AccountState.Overdrawn
            | _ when balance > 0.0<_> && balance < 10000.0<_> -> AccountState.Silver
            | _ -> AccountState.Gold

    member this.PayInterest() =
        let interest = 
            match this.State with
                | AccountState.Overdrawn -> 0.
                | AccountState.Silver -> 0.01
                | AccountState.Gold -> 0.02
        interest * balance

    member this.Deposit x = balance <- balance + x
    member this.Withdraw x = balance <- balance - x

let measureSample() =
    let account = Account<USD>()
    let USDAmount = LanguagePrimitives.FloatWithMeasure 10000.
    account.Deposit USDAmount
    printfn "US interest = %A" (account.PayInterest())
    
    let canadaAccount = Account<CND>()
    let CADAmount : float<CND> = LanguagePrimitives.FloatWithMeasure 10000.
    canadaAccount.Deposit CADAmount
    printfn "Canadian interest = %A" (canadaAccount.PayInterest())

measureSample()