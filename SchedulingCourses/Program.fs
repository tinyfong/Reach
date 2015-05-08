    seq {1..100}
    |>Seq.filter(fun n->n%2<>0)
    |>Seq.sum
    |>printfn "sun is %A"