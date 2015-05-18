module File5

type MyClass<'T when 'T : null> () =
    let a:'T = Unchecked.defaultof<'T>

let b = MyClass<string []>()

let b3 = MyClass<string seq>()

type MyRecord = { X : int; Y : string }

let b4 = MyClass<System.Tuple<string, string>>()

let b5 = MyClass<System.Tuple<string, string>>()

type MyClass2() = class end

