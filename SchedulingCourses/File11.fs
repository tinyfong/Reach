module File11

// Defining a record and creating a record
type Point2D = { x: float; y: float}
type Point = { x: float; y: float }
type Student = { Name: string; Age: decimal; }
type Person = { First: string
                Last: string }

let point2DRecord = { Point2D.x = 1.; Point2D.y = 2. }
let pointRecord = { Point.x = 1.; Point.y = 2. }

let studentRecord = { Name = "John"; Age = 18m; }
let personRecord = { First = "Chris" 
                     Last = "Root" }

// Record copying
type Person1 = { First : string
                 Last : string }                     

let personRecord1 = { First = "Chris" 
                      Last = "Root" }

let personRecord2 = { personRecord1 with First = "Matt" }

// Using a record type in serialization
type Demographics = Microsoft.FSharp.Data.TypeProviders.ODataService<ServiceUri = "https://api.datamarket.azure.com/Data.ashx/uk.gov/traveladvisoryservice/">

let ctx = Demographics.GetDataContext()

ctx.Credentials <- System.Net.NetworkCredential()

[<CLIMutableAttribute>]
type NewsRecord = { Title : string; Summary : string }

let lastestNews = query {
    for n in ctx.LatestTravelNewsFromFco do
    select { NewsRecord.Title = n.Title; NewsRecord.Summary = n.Summary }
}

let news = lastestNews |> Seq.toArray

