
    let input=[1..10]

    let join1 : string*string list-> string =System.String.Join

    let curryFormatJoin = FuncConvert.FuncFromTupled join1

    input
    |> List.map(fun number->string (number))
    |> curryFormatJoin "*"