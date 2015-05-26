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

    let newT = ProvidedTypeDefinition(thisAssembly, rootNamespace, "TPTestType",Some baseTy)

    let m = ProvidedMethod(
                methodName = "methodName",
                parameters = [], 
                returnType = typeof<int>,
                IsStaticMethod = false,
                InvokeCode = fun args ->
                    <@@ 1+1 @@>
        )

    let ctor = ProvidedConstructor(parameters = [], InvokeCode = fun args -> <@@ (* base class initialization or null*) () @@>)

    let prop2 = ProvidedProperty(propertyName = "property1",
                                 propertyType = typeof<string>,
                                 IsStatic = false,
                                 GetterCode = (fun args -> <@@ "Hello!" @@>),
                                 SetterCode = (fun args -> <@@ printfn "setter code " @@>)
                                 )

    do prop2.AddXmlDocDelayed(fun () -> "xml comment")

    do 
        newT.AddMember(m)
        newT.AddMember(prop2)
        newT.AddMember(ctor)

    do this.AddNamespace(rootNamespace, [newT])

[<TypeProviderAssembly>]
do()