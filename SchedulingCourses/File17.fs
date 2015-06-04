module File17

// Spawning a thread

open System.Threading 
open System

let thread() =
    [1..5]
    |> Seq.iter (fun _ -> Thread.Sleep 1000;
                            printfn "%A from thread %d"
                                DateTime.Now
                                Thread.CurrentThread.ManagedThreadId)

let spawn() =
    let thread = Thread thread
    thread.Start()

spawn()
spawn()


// Using lock in a long thread execution
open System
open System.Threading

let synRoot = ref 0
let presenterFunction() =
    let id  = Thread.CurrentThread.ManagedThreadId
    printfn "I (%d) starting, please do not interrupt..." id
    Thread.Sleep 1000
    printfn "I (%d) finished, thank you!" id

let longTalk() =
    lock(synRoot) (fun() -> presenterFunction())

ThreadPool.QueueUserWorkItem(fun _ -> longTalk()) |> ignore
ThreadPool.QueueUserWorkItem(fun _ -> longTalk()) |> ignore
ThreadPool.QueueUserWorkItem(fun _ -> longTalk()) |> ignore


// An asynchronous workflow sample with a generalized function interface
type AsyncSample(l:seq<int>) =
    member this.AreAll(compareFunction) =
        let num = ref 0

        let inc () = lock(num) (fun _ -> num := (!num) + 1)

        let windowedList = l |> Seq.windowed 2

        let compare s =
            async {
                let list =List.ofSeq s
                let [ x; y ] = list

                if compareFunction x y then inc()
                else()
                }

        let compute =
            windowedList
            |> Seq.map compare
            |> Async.Parallel
            |> Async.RunSynchronously

        (!num) + 1 = Seq.length l

let asyncObj = AsyncSample(seq {1..10})
let r1 = asyncObj.AreAll(<)