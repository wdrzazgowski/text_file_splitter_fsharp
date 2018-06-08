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

let writeStringArrayToFile (lines: list<string>) (outputFileName: string) =
    use sw = new System.IO.StreamWriter(outputFileName)
    lines |> Seq.iter(sw.WriteLine)
    sw.Close()

let readFile filePath =
    File.ReadAllLines filePath
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

