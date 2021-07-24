open System
#nowarn "25"

let inline readLine typeOperator = stdin.ReadLine() |> typeOperator
let inline readArray typeOperator = stdin.ReadLine().Split ' ' |> Array.map typeOperator
let modval = 1000000007

let NK = readArray int
let N = NK.[0]
let K = NK.[1]
let d = Array.zeroCreate K
let A = Array2D.zeroCreate K N
for i in 0 .. K - 1 do
    d.[i] <- readLine int
    let Aline = readArray int
    for j in 0 .. d.[i] - 1 do
        A.[i, j] <- Aline.[j]
eprintfn "%A" A

let haveSweets = Array.create N false
for i in 0 .. K - 1 do
    for j in 0 .. N - 1 do
        let snuk = A.[i, j]

        if snuk > 0 then
            haveSweets.[A.[i, j] - 1] <- true
eprintfn "%A" haveSweets
haveSweets
    |> Seq.filter not
    |> Seq.length
    |> printfn "%d"
