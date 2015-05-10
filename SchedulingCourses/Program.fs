    let isDivisibleBy number elem =elem % number =0

    let result=Seq.find(fun n-> isDivisibleBy 6 n)[1..100]
    printfn "%d" result
