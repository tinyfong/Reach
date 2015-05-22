module InMemoryTable

open System
open System.Linq
open Microsoft.FSharp.Linq.NullableOperators

type Student() =
    member val Id = 0 with get, set
    member val Name = "" with get, set
    member val Age = Nullable(0) with get, set

let showResult query = query |> Seq.iter(printfn "%A")

let studentTable = [
    Student(Id = 1, Name = "Anita", Age = Nullable(22));
    Student(Id = 2, Name = "Kata", Age = Nullable(22))
    Student(Id = 3, Name = "Brent", Age = Nullable(23))
    Student(Id = 4, Name = "LIsa", Age = Nullable(23))
    Student(Id = 5, Name = "Mark", Age = Nullable(24))].AsQueryable()

