#r @".\bin\Debug\HelloWorldTypeProvider.dll"

let assertFunction x =
    if not x then failwith "expression is false"

type T = Samples.ShareInfo.TPTest.HelloWorldTypeProvider

let t = T()


