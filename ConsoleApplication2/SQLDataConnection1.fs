module SQLDataConnection1

#if INTERACTIVE
#r "System.Data"
#r "System.Data.Linq"
#r "FSharp.Data.TypeProviders"
#r "System.Linq"
#endif

open System.Data
open System.Data.Linq
open System.Linq
open Microsoft.FSharp.Data.TypeProviders
open Microsoft.FSharp.Linq.NullableOperators

type SqlConnection = SqlDataConnection<ConnectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=Institute;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", StoredProcedures=false>

let db = SqlConnection.GetDataContext()
let showResult query = query |> Seq.iter(printfn "%A")

let internal q0 = query {
    for n in db.Course do
    select n.CourseName
    }

let internal q1 = query {
    for n in db.Course.AsEnumerable() do
    select (sprintf "course name = %s" n.CourseName) }


showResult q1

let A = [0; 2; 4; 5; 6; 8; 9]
let B = [1; 3; 5; 7; 8]

query{ 
    for a in A do
    for b in B do
    where (a < b)
    select (a, b)
}
|> Seq.iter(fun (n, e) -> printfn "%d is less than %d" n e)

let internal q2 = query {
    for n in db.Student do
    where (n.Name.Length > 4)
    select n.Name }

showResult q2

let internal q3 = query {
    for n in db.Student do
    select n.Name
    }
let q3_2 = q3 |> Seq.filter(fun n -> n.Length > 4)
showResult q3_2

let internal myQuery = query {
    for n in db.Student do
    select n.Name}

let result =
    myQuery
    |> Seq.mapi(fun i n -> (i, n))
    |> Seq.filter(fun (i, n) -> i % 2 = 0)
    |> showResult

let internal q5 = query {
    for student in db.Student do
    leftOuterJoin selection in db.CourseSelection on
        (student.StudentId = selection.StudentId) into result
    for selection1 in result do
    select (student.Name)
    }

showResult q5

let q6 = query {
    for student in db.Student do
    groupJoin courseSelection in db.CourseSelection
        on (student.StudentId = courseSelection.StudentId) into g
    for  courseSelection in g do
    join course in db.Course on (courseSelection.CourseId ?= course.CourseId)
    select (student.Name, course.CourseName)
    }

showResult q6

let internal q4 = query {
    for n in db.Student do 
    sortByDescending n.Name 
  
    select n.Name }
showResult q4

let internal q7 = query {
    for student in db.Student do
    groupBy student.Age into g
    select (g.Key, g.Count())}

showResult q7

let internal q8 = query {
    for student in db.Student do
    groupValBy student.Name student.Age into g
    select (g, g.Key, g.Count()) }

showResult q8

let internal q11 = query {
    for student in db.Student do
    sumByNullable student.Age}

showResult [q11]

let internal q15 = query {
    for student in db.Student do
    select student.Name
    count }

let internal q22 = query {
    for student in db.Student do
    all (SqlClient.SqlMethods.Like(student.Name, "L%"))}
showResult [q22]

let internal q23 = query {
    for student in db.Student do
    where (student.Name = "Lisa")
    exactlyOne }
showResult [q23.Name]

let ids = query { for id in [1;2;3] do  select id}
   
let qq= query { 
    for student in db.Student do
    where (ids.Contains(student.StudentId))
    select student }
