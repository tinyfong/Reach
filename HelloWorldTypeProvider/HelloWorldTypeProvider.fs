namespace Samples.FSharp.HelloWorldTypeProvider

open System.Reflection
open Microsoft.FSharp.Core.CompilerServices
open Samples.FSharp.ProvidedTypes

[<TypeProvider>]
type public TypeProvider1() as this =
    inherit TypeProviderForNamespaces()

    let thisAssembly = Assembly.GetExecutingAssembly()
    let rootNamespace = "Samples.ShareInfo.TPTest"
    let baseTy = typeof<obj>

    let newT = ProvidedTypeDefinition(thisAssembly, rootNamespace, "HelloWorldTypeProvider",Some baseTy)
    let ms =
        [1..5]
        |> List.map (fun i -> 
                         let m = ProvidedMethod(
                                    methodName = sprintf "Method%d" i,
                                    parameters = [], 
                                    returnType = typeof<int>,
                                    IsStaticMethod = false,
                                    InvokeCode = fun args ->
                                    <@@ i @@>)
                         m)

    let ctor = ProvidedConstructor(parameters = [], InvokeCode = fun args -> <@@ (* base class initialization or null*) () @@>)

    let props =
        [6..10]
        |> List.map(fun i ->
                        let prop2 = 
                             ProvidedProperty(
                                             propertyName = sprintf "Property%d" i,
                                             propertyType = typeof<string>,
                                             IsStatic = false,
                                             GetterCode = (fun args -> <@@ sprintf "Property %d" i @@>),
                                             SetterCode = (fun args -> <@@ () @@>))
                        prop2.AddXmlDocDelayed(fun () -> sprintf "xml comment for Property%d" i)
                        prop2)
   
    do 
        ms |> Seq.iter newT.AddMember
        props |> Seq.iter newT.AddMember
        newT.AddMember(ctor)

    do this.AddNamespace(rootNamespace, [newT])

[<TypeProviderAssembly>]
do()