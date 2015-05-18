module File4
open System
open System.Data.SqlClient

type Database(conString) =
    let con = new SqlConnection(conString)
    member this.ConnectionString = conString
    member this.Connect() =
        con.Open()
    member this.Close() = con.Close()
    interface IDisposable with
        member this.Dispose() = this.Close()

let testIDisposable() =
    use db = new Database("my connection string")
    db.Connect()

let testUsing(db:Database) = db.Connect ()
using (new Database("my connection string")) testUsing