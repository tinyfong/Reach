    let s1 =seq{1..5}
    let s2=seq{2..2..10}

    if  Seq.forall2(fun x y ->x*2=y)  s1 s2 then printfn "OK"