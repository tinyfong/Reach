namespace Samples .FSharp.RegularExpressionTypeProvider

open System.Reflection
open Microsoft.FSharp.Core.CompilerServices
open Samples.FSharp.ProvidedTypes
open System.Text.RegularExpressions

[<TypeProvider>]
type public TypeProvider1() as this=
    inherit TypeProviderForNamespaces()
       
    let thisAssembly = Assembly.GetExecutingAssembly()
    let rootNamespace = "Samples.ShareInfo.TPTest"
    let baseTy = typeof<obj>
    
    let newT = ProvidedTypeDefinition(thisAssembly, rootNamespace, "RegularExpressionTypeProvider", Some baseTy)

    let staticParams = [ProvidedStaticParameter("pattern",typeof<string>)]
    do newT.DefineStaticParameters(
            parameters = staticParams,
            instantiationFunction = (fun typeName parameterValues ->
                match parameterValues with
                | [| :? string as pattern|] ->
                    let ty = ProvidedTypeDefinition (
                                thisAssembly,
                                rootNamespace,
                                typeName,
                                Some baseTy,
                                HideObjectMethods = true)
                    let r = System.Text.RegularExpressions.Regex(pattern)
                    let m = ProvidedMethod(
                                methodName = "IsMatch",
                                parameters = [ProvidedParameter("input", typeof<string>)],
                                returnType = typeof<bool>,
                                IsStaticMethod = true,
                                InvokeCode = fun args ->
                                    <@@ System.Text.RegularExpressions.Regex.IsMatch(
                                         (%%args.[0]:string), pattern) @@>
                                )

                    ty.AddMember(m)
                   
                    let ctor = ProvidedConstructor(
                                            parameters = [], 
                                            InvokeCode = fun args -> <@@ System.Text.RegularExpressions.Regex (pattern) :> obj 
                                            @@>) 
                               
                    ty.AddMember(ctor)

                    let matchTy = ProvidedTypeDefinition("Match",
                                    baseType = Some baseTy,
                                    HideObjectMethods = true)      

                    for group in r.GetGroupNames() do
                        if group <> "0" then
                          let prop = ProvidedProperty(
                                        propertyName = group, 
                                        propertyType = typeof<Group>, 
                                        GetterCode= fun args -> 
                                        <@@ 
                                        ((%%args.[0]:obj) :?> Match).Groups.[group]
                                        @@>)                                      

                          matchTy.AddMember prop
                    
                    let matchMethod =
                          ProvidedMethod(
                                    methodName = "Match", 
                                    parameters = [ProvidedParameter("input", typeof<string>)],
                                    returnType = matchTy,                                   
                                    InvokeCode= fun args -> 
                                    <@@
                                        ((%%args.[0]:obj) :?> Regex).Match(%%args.[1]):> obj
                                    @@>)
                                  
                    ty.AddMember(matchMethod)
                    ty.AddMember(matchTy)
                    
                    ty
                ))
    do this.AddNamespace(rootNamespace, [newT])
[<TypeProviderAssembly>]
do()