import kotlin.math.*

const val mod = 10000007

fun readln() = readLine() ?: ""
inline fun <T> readln(parser: String.() -> T): T = readln().parser()
fun readList() = readln().split(' ')
inline fun <T> readList(parser: (String.() -> T)): List<T> = readList().map { it.parser() }
fun eprintln(message: String) = System.err.println(message)
fun main() {
    val (N, M) = readList { toInt() }
    val A = readList { toInt() }.asSequence().distinct().sorted().toList()
    val B = readList { toInt() }.asSequence().distinct().sorted().toList()
    var minDiff = Int.MAX_VALUE
    var i = 0
    var j = 0
    while (i < A.size && j < B.size) {
        val a = A[i]
        val b = B[j]
//        eprintln("a: $a, b: $b, i: $i, j: $j, min: $minDiff")
        minDiff = min(minDiff, abs(a - b))
        if (a < b) i++
        else j++
    }
    println(minDiff)
}
