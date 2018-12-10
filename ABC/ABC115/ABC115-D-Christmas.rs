#[allow(unused_imports)]
use std::cmp;
#[allow(unused_imports)]
use std::collections::*;
use std::usize;
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
        x: usize,
    }
    let mut lenb: Vec<usize> = Vec::new();
    let mut cntp: Vec<usize> = Vec::new();

    for i in 0..n + 1 {
        if i == 0 {
            lenb.push(1);
            cntp.push(1);
            continue;
        }
        let prevlen = lenb[i - 1];
        let prevcnt = cntp[i - 1];
        lenb.push(prevlen * 2 + 3);
        cntp.push(prevcnt * 2 + 1);
    }
    // eprintln!("{:?}", lenb);
    // eprintln!("{:?}", cntp);

    println!("{}", calcp(n, x, lenb, cntp));
}

fn calcp(l: usize, x: usize, lenb: Vec<usize>, cntp: Vec<usize>) -> usize {
    // eprintln!("{} {}", l, x);
    if l == 0 {
        if x > 0 {
            return 1;
        } else {
            return 0;
        }
    } else if lenb[l] <= x {
        return cntp[l];
    } else if lenb[l] / 2 < x {
        return calcp(l - 1, x - lenb[l - 1] - 2, lenb, cntp.clone()) + 1 + cntp[l - 1];
    } else if lenb[l] / 2 == x {
        return cntp[l - 1];
    } else if l < x {
        return calcp(l - 1, x - 1, lenb, cntp);
    } else {
        return 0;
    }
}
