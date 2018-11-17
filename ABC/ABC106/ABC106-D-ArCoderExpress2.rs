#[allow(unused_imports)]
use std::cmp;
#[allow(unused_imports)]
use std::collections::*;
#[allow(unused_imports)]
use std::vec::Vec;

macro_rules! input {
    (source = $s:expr, $($r:tt)*) => {
        let mut iter = $s.split_whitespace();
        let mut next = || { iter.next().unwrap() };
        input_inner!{next, $($r)*}
    };
    ($($r:tt)*) => {
        let stdin = std::io::stdin();
        let mut bytes = std::io::Read::bytes(std::io::BufReader::new(stdin.lock()));
        let mut next = move || -> String{
            bytes
                .by_ref()
                .map(|r|r.unwrap() as char)
                .skip_while(|c|c.is_whitespace())
                .take_while(|c|!c.is_whitespace())
                .collect()
        };
        input_inner!{next, $($r)*}
    };
}

macro_rules! input_inner {
    ($next:expr) => {};
    ($next:expr, ) => {};

    ($next:expr, $var:ident : $t:tt $($r:tt)*) => {
        let $var = read_value!($next, $t);
        input_inner!{$next $($r)*}
    };
}

macro_rules! read_value {
    ($next:expr, ( $($t:tt),* )) => {
        ( $(read_value!($next, $t)),* )
    };

    ($next:expr, [ $t:tt ; $len:expr ]) => {
        (0..$len).map(|_| read_value!($next, $t)).collect::<Vec<_>>()
    };

    ($next:expr, chars) => {
        read_value!($next, String).chars().collect::<Vec<char>>()
    };

    ($next:expr, usize1) => {
        read_value!($next, usize) - 1
    };

    ($next:expr, $t:ty) => {
        $next().parse::<$t>().expect("Parse error")
    };
}

fn main() {
    input!{
        n: usize,
        m: usize,
        q: usize,
        lr: [(usize, usize);m],
        pq: [(usize, usize);q],
    }
    let mut table = vec![vec![0; n + 1]; n + 1];
    for (l, r) in lr {
        table[l][r] += 1;
    }
    // for i in 0..n + 1 {
    //     eprintln!("{:?}", table[i]);
    // }
    // eprintln!();
    for i in 1..n + 1 {
        for j in 1..n + 1 {
            table[i][j] += table[i][j - 1];
        }
    }
    for i in 1..n + 1 {
        for j in 1..n + 1 {
            table[i][j] += table[i - 1][j];
        }
    }
    // for i in 0..n + 1 {
    //     eprintln!("{:?}", table[i]);
    // }
    // eprintln!();
    for (p, q) in pq {
        let result = table[q][q] + table[p - 1][p - 1] - table[p - 1][q] - table[q][p - 1];
        println!("{}", result);
    }
}
