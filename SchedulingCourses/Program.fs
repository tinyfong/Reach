namespace MyNamespace
type Point2D(xValue:double,yValue:double)=
    let mutable x=xValue
    member this.X with get()=x
                  and set(v) =x<-v

    member val Y = yValue with get,set

    member this.GetDistance (point:Point2D)=
        let xDif=this.X-point.X
        let yDif=this.Y-point.Y
        let distance =sqrt(xDif**2.+yDif**2.)
        distance

    static member fromXY (x:double, y:double)=
        Point2D(x,y)
      


type Screen()=
    let points =System.Collections.Generic.List<Point2D>()

    member this.Item with get(x) = points.[x]
                     and set x v=points.[x]<-v

            