namespace FSharp.Converters

open System
open System.Windows
open System.Windows.Data
open Microsoft.FSharp.Reflection

[<AutoOpen>]
module FunctionLibrary =
    let nullFunction = fun value _ _ _ -> value
    
    let stringToInt (a:Object) = Convert.ToInt32(a)
    let intToBool = fun i -> i = 0
    let boolToVisibility = fun b ->
        if b then Visibility.Visible
        else Visibility.Collapsed

    let convert<'T> f (obj:System.Object) (t:Type) (para:System.Object) (culture:Globalization.CultureInfo) = (obj :?> 'T) |> f |>box
        
    [<AbstractClassAttribute>]
    type ConverterBase(convertFunction, convertBackFunction) =
        new() = ConverterBase(nullFunction, nullFunction)

        interface IValueConverter with
            override this.Convert (value, targetType, parameter, culture) =
                this.Convert value targetType parameter culture
            override this.ConvertBack(value, targetType, parameter, culture) =
                this.ConvertBack value targetType parameter culture
        abstract member Convert : (obj -> Type -> obj -> Globalization.CultureInfo -> obj)
        default this.Convert = convertFunction

        abstract member ConvertBack : (obj -> Type -> obj -> Globalization.CultureInfo -> obj)
        default this.ConvertBack = convertBackFunction

    type StringToVisiblityConverter() =
        inherit ConverterBase(stringToInt >> intToBool >> boolToVisibility |> convert, nullFunction)
    
    type DebuggerConverter() =
        inherit ConverterBase(nullFunction, nullFunction)