module File2

type I2DLocation = interface
    abstract member X : float with get, set
    abstract member Y : float with get, set
    end

type IPoint2D = interface
    inherit I2DLocation
    abstract member GetDistance<'T when 'T :> I2DLocation> : I2DLocation -> float 
    end

[<System.Diagnostics.DebuggerDisplay("({X}, {Y})")>]
type Point2D (xValue:double, yValue:double) = class
    let mutable x = xValue
    
    new() = Point2D(0.,0.)

    member this.Print(msg) = printfn "%s" msg
    member this.X with get() = x and set(v) = x <- v
    member val Y = yValue with get,set

    abstract GetDistance<'T when 'T :> I2DLocation> : point:'T -> double
    default this.GetDistance<'T when 'T :> I2DLocation > (point:'T)=
        let xDif = this.X - point.X
        let yDif = this.Y - point.Y
        let distance =sqrt(xDif**2.+yDif**2.)
        distance

    static member FromXY (x:double, y:double)=
        Point2D(x, y)

    static member (+) (point:Point2D, offset:double) =
        Point2D(point.X + offset, point.Y + offset)

    static member (~-) (point:Point2D) =
        Point2D(-point.X, -point.Y)

    interface I2DLocation with
        member this.X with get() = this.X and set(v) = this.X <- v
        member this.Y with get() = this.Y and set(v) = this.Y <- v
    end
    
    interface IPoint2D with
        member this.GetDistance<'T when 'T :> I2DLocation >(p) = this.GetDistance(p)
    end          

    override this.ToString() =
        sprintf "Point2d(%f, %f)" this.X this.Y
    end

module TestModule=
    let c = Point2D(2., 2.)
    let d = -c
    let originalPoint = d + 2.
    

type Particle() =
    inherit Point2D()
    member val Mass = 0. with get, set
    override this.ToString() =
        sprintf "Particle_%s with Mass=%f" (base.ToString()) this.Mass

type Student(nameIn: string, idIn: int)=class
    let mutable name = nameIn
    let mutable id = idIn
    
    do printfn "Create a student object"

    member this.Name with get() = name and set(v) = name <- v
    member this.ID with get() = id and set(v) = id <- v
    
    new() =
        Student("Invalid student name",-1)
        then printfn "Created an invalid student object. Please input student name."
    end


type Screen() =
    let points = System.Collections.Generic.List<Point2D>()
    let width = 800
    let height = 600
    do 
        points.AddRange(Seq.init(width*height)(fun _ -> Point2D()))
        
    member this.Item with get(x:int) = points.[x] 
                     and set(x:int) v= points.[x] <-v
    member this.Item with get(x:int, y:int) = points.[x + width*y] 
                     and set(x:int, y:int) v= points.[x + width*y] <-v



