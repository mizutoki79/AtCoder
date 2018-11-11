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
        d: usize,
        g: usize,
        pc: [(usize, usize); d],
    };
    let mut min = usize::max_value();
    for complete_flag in 0..(1 << d) {
        let mut score = 0;
        let mut count = 0;
        for i in 0..d {
            if complete_flag & (i + 1) != 0 {
                score += (i + 1) * 100 * pc[i].0 + pc[i].1;
                count += pc[i].0;
            }
        }
        if score < g {
            continue;
        }
        min = cmp::min(min, count);
        for i in 0..d {
            if complete_flag & 1 << i == 0 {
                continue;
            }
            let mut remain = pc[i].0;
            score -= pc[i].1;
            while score >= g && remain > 0 {
                score -= (i + 1) * 100;
                count -= 1;
                remain -= 1;
            }
            if score >= g {
                continue;
            }
            count += 1;
            min = cmp::min(min, count);
        }
    }
    println!("{}", min);
}
