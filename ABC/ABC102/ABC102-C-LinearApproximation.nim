import algorithm, intsets, sequtils, strutils
let n = stdin.readLine.parseInt
var a = stdin.readLine.split.map(parseInt)
for i in 0..n - 1:
    a[i] -= i + 1
a.sort(cmp)
let b = a[int(n / 2)]
var result = 0;
for i in 0..n - 1:
    result += abs(a[i] - b)
echo result
