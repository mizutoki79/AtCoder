open System
// #nowarn "25"

let inline readLine typeOperator = stdin.ReadLine() |> typeOperator
let inline readArray typeOperator = stdin.ReadLine().Split ' ' |> Array.map typeOperator
let modval = 1000000007

let S = readLine string
let N = String.length S
let counts = Array.zeroCreate 8
for i in N - 1 .. -1 .. 0 do
    let ch = S.[i]
    ch |> function
    | 'c' -> counts.[0] <- (counts.[0] + counts.[1]) % modval
    | 'h' -> counts.[1] <- (counts.[1] + counts.[2]) % modval
    | 'o' -> counts.[2] <- (counts.[2] + counts.[3]) % modval
    | 'k' -> counts.[3] <- (counts.[3] + counts.[4]) % modval
    | 'u' -> counts.[4] <- (counts.[4] + counts.[5]) % modval
    | 'd' -> counts.[5] <- (counts.[5] + counts.[6]) % modval
    | 'a' -> counts.[6] <- (counts.[6] + counts.[7]) % modval
    | 'i' -> counts.[7] <- counts.[7] + 1
    | _ -> ()
printfn "%d" counts.[0]
