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
        x: chars,
    }
    let mut prev_v;
    let mut prev_i;
    let mut curr_v = x[0];
    let mut curr_i = 0;
    let mut leng = x.len();
    let mut removed = vec![false; leng];
    for (i, &ch) in x.iter().enumerate() {
        prev_v = curr_v;
        prev_i = curr_i;
        curr_v = ch;
        curr_i = i;
        if prev_v == 'S' && curr_v == 'T' {
            leng -= 2;
            removed[prev_i] = true;
            removed[curr_i] = true;
            let curr = removed
                .iter()
                .enumerate()
                .filter(|&(idx, _)| idx < i)
                .rev()
                .skip_while(|&(_, &flag)| flag)
                .next();
            if let Some(curr) = curr {
                curr_i = curr.0;
                curr_v = x[curr_i];
            }
        }
        for (i, &ch) in x.iter().enumerate() {
            if !removed[i] {
                eprint!("{}", ch);
            }
        }
        eprintln!();
    }
    println!("{}", leng);
}
