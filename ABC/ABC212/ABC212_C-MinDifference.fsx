open System
// #nowarn "25"

let inline readLine typeOperator = stdin.ReadLine() |> typeOperator
let inline readArray typeOperator = stdin.ReadLine().Split ' ' |> Array.map typeOperator
let modval = 1000000007

let (N,M) = readArray int |> function
        | [|var1;var2|] -> (var1,var2)
        | _ -> failwith "invalid input"
let A = readArray int |> Seq.distinct |> Seq.sort |> Seq.toArray
let B = readArray int |> Seq.distinct |> Seq.sort |> Seq.toArray
let mutable i = 0
let mutable j = 0
let mutable minDiff = Int32.MaxValue
while i < Seq.length A && j < Seq.length B do
    let a = A.[i]
    let b = B.[j]
    minDiff <- a - b |> abs |> min minDiff
    if a < b then i <- i + 1
    else j <- j + 1
printfn "%d" minDiff
