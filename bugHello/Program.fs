// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open bugLib

[<EntryPoint>]
let main argv =
    Say.hello "World!"
    Say.goodbye "World!" 
    //Neither of the above methods exist now
    0 // return an integer exit code