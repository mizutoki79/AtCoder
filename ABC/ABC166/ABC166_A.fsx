open System
#nowarn "25"

let inline readLine typeOperator = stdin.ReadLine() |> typeOperator
let inline readArray typeOperator = stdin.ReadLine().Split ' ' |> Array.map typeOperator
let modval = 1000000007

let S = readLine
printfn "%s" (if stdin.ReadLine() = "ABC" then "ARC" else "ABC")
