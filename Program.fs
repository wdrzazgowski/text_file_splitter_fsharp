// Learn more about F# at http://fsharp.org

open System
open System.IO
open System.Collections.Generic


//let writeFile (lines : IEnumerable<string>) =
//    use file = File.AppendText(@".\test.txt")
//   lines |> Seq.iter( fun x -> file.WriteLine(x))
    



(*let rec writeFile (lines: list<string>) (count: int) = 
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


(*
module Seq =

    /// Returns a sequence that yields chunks of length n.
    /// Each chunk is returned as a list.
    let split length (xs: seq<'T>) =
        let rec loop xs =
            [
                yield Seq.truncate length xs |> Seq.toList
                match Seq.length xs <= length with
                | false -> yield! loop (Seq.skip length xs)
                | true -> ()
            ]
        loop xs

// Demo
[1 .. 20]
|> Seq.split 3
|> Seq.toArray

// Output
// [|[1; 2; 3]; [4; 5; 6]; [7; 8; 9]; [10; 11; 12]; [13; 14; 15]; [16; 17; 18];
// [19; 20]|]
*)


let writeStringArrayToFile (lines: list<string>) (outputFileName: string) =
    use sw = new System.IO.StreamWriter(outputFileName)
    lines |> Seq.iter(sw.WriteLine)
    sw.Close()


let rec readLinesIntoArray sr index = 
    match sr.ReadLine with
    | line -> 

let readFile filePath =
    use sr = new System.IO.StreamReader(filePath)
    let index = 0
    
    match sr.ReadLine() with
    | line -> result[index / 1000].add line;  
    | null -> sr.Close(); None 
    
    //File.ReadAllLines filePath

[<EntryPoint>]
let main argv =
    let inputFilePath = argv.[0]
    let outputFilePath = argv.[1]

    printfn "Reading content of %s file" inputFilePath
    let lines = readFile inputFilePath
    printfn "Line count: %i" lines.Length

    printfn "Writing file %s" outputFilePath
    
    let lineList = lines |> List.ofArray

    writeStringArrayToFile lineList outputFilePath |> ignore

    0 // return an integer exit code

