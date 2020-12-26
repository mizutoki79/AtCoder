open System
#nowarn "25"

let inline readLine typeOperator = stdin.ReadLine() |> typeOperator
let inline readArray typeOperator = stdin.ReadLine().Split ' ' |> Array.map typeOperator
let modval = 1000000007


/// エラトステネスの篩による素数リスト生成
let sievePrimes num =
    let sieve = Seq.init (num + 1) (fun i -> if i < 2 then 0 else i) |> Array.ofSeq
    let isPrimes = Array.zeroCreate<bool> (num + 1)
    eprintfn "%d %d" sieve.Length isPrimes.Length
    let maxIndex = num |> double |> sqrt |> ceil |> int
    for i in 2..maxIndex do
        if sieve.[i] = i then
            isPrimes.[i] <- true
            if double i <= sqrt (double num) then
                for j in (i * i)..i..num do
                    sieve.[j] <- min sieve.[j] i
    sieve, isPrimes

/// modの二分累乗法
/// a^n mod m を求める
let modpow a n m =
    let rec recModPow a n m res =
        if n <= 0 then res
        elif n &&& 1 = 1 then recModPow (a * a % m) (n >>> 1) m (res * a % m)
        else recModPow (a * a % m) (n >>> 1) m res
    recModPow a n m 1

/// modの世界での逆元を求める
/// num^(-1) mod m を求める
let modInverse num m =
    let rec recModInverse a b u v =
        let t = a / b
        let a' = a - t * b
        let a, b = b, a'
        let u' = u - t * v
        let u, v = v, u'
        b |> function
        | 0L -> u
        |_ -> recModInverse a b u v
    let a, b, u, v = num, m, 1L, 0L
    let u = recModInverse a b u v
    if u < 0L then (u + m) else u


// eprintfn "main"
let n = readLine int
// eprintfn "%d" n
let A = readArray int
// eprintfn "%A" A
let maxA = A |> Seq.max
// eprintfn "maxA: %d" maxA
let sieve, isPrimes = sievePrimes maxA
// eprintfn "sieve: %A" sieve
// eprintfn "isPrimes: %A" isPrimes
let maxCounts = Array.zeroCreate<int> (maxA + 1)
// eprintfn "count"
//TODO: 再帰関数でループさせる
for elem in A do
    let mutable num = elem
    while num > 1 do
        let p = sieve.[num]
        let mutable cnt = 0
        while num % p = 0 do
            num <- num / p
            cnt <- cnt + 1
        maxCounts.[p] <- max maxCounts.[p] cnt
// eprintfn "calced primeCounts: %A" maxCounts
// eprintfn "mod lcm"
let modlcm =
    Seq.init (maxA + 1) (fun i -> modpow i maxCounts.[i] modval)
    |> Seq.map int64
    |> Seq.fold (fun acc elem -> (int64 acc) * (int64 elem) % (int64 modval)) 1L
// eprintfn "mod lcm: %d" modlcm
// eprintfn "answer"
A |> Seq.map (fun ai -> modlcm * (modInverse (int64 ai) (int64 modval)) % (int64 modval))
|> Seq.fold (fun acc elem -> (acc + elem) % (int64 modval)) 0L
|> printfn "%d"
