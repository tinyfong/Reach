module SQLDataConnection1

#if INTERACTIVE
#r "System.Data"
#r "System.Data.Linq"
#r "FSharp.Data.TypeProviders"
#endif

open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders

type SqlConnection = SqlDataConnection<ConnectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=Institute;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", StoredProcedures=false>

let db = SqlConnection.GetDataContext()

let table =query {
    for r in db.Course do
    select r
    }
    
let newRecord = new SqlConnection.ServiceTypes.Course(CourseName = "aa")

db.Course.InsertOnSubmit(newRecord)
try
    db.DataContext.SubmitChanges()
    printfn "record added"
with _ -> printfn "update failed"

db.Course .DeleteOnSubmit(newRecord)
try
    db.DataContext.SubmitChanges()
    printfn "record deleted"
with _ -> printfn "update failed"


//for p in table do 
//    printfn"%s" p.CourseName
