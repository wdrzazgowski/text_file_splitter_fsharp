// Learn more about F# at http://fsharp.org

open System
open System.IO
open System.Collections.Generic


//let writeFile (lines : IEnumerable<string>) =
//    use file = File.AppendText(@".\test.txt")
//   lines |> Seq.iter( fun x -> file.WriteLine(x))
    


(*
let rec writeFile (lines: list<string>) (count: int) = 
    match lines with
    | [] -> printf "Koniec."
    | first::rest ->
        let reminder = count / 1000
        let fileName = String.Format(".\\text{0}.txt", reminder)
        let file = File.AppendText(fileName)
        file.WriteLine first
        file.Flush
        file.Close
        file.Dispose
        writeFile rest (1 + count)
*)


[<EntryPoint>]
let main argv =
    let inputFilePath = argv.[0]
    printfn "Reading content of %s file" inputFilePath
    let lines = File.ReadAllLines inputFilePath

    printfn "Line count: %i" lines.Length

    type StringList = list<string>

    initialValue: StringList list
    let initialValue = []
    let count = 1
    let action (count, listSoFar) x = 
        

    //let count = 0
    //writeFile (lines |> List.ofArray) count
    //lines |> Seq.iter( fun x -> printfn "%s" x)
    0 // return an integer exit code

