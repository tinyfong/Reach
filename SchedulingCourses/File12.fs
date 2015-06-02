module File12

// Defining a discriminated union
type Shape =
    | Circle of double
    | Triangle of double * double * double
    | Rectangle of double * double

type Number = OddNumber | EvenNumber

// Defining a tree structure using a DU
type Tree =
    | Tip of NodeType
    | Node of int * Tree *Tree
    override this.ToString() = "this is a Tree DU"
and NodeType =
    | NodeContent of int
    override this.ToString() = "this is NodeType DU"


// DU with an interface
type IShape =
    abstract Area : double with get

type ShapeWithInterface =
    | Circle of double
    | Triangle of double * double * double
    | Rectangle of double * double
    interface IShape
        with member this.Area =
            match this with
            | Circle(r) -> r * r * System.Math.PI
            | Triangle(a, b, c) ->
                let s = (a + b + c)/2.
                sqrt(s * (s-a) * (s-b) * (s-c))
            | Rectangle(a, b) -> a * b
    override this.ToString() = "This is a ShapeWithInterface type"

let getArea2 (shape: IShape) = shape.Area
let r1 = getArea2(Circle(4.))