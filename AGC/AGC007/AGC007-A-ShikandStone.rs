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
        h: usize,
        w: usize,
        a: [chars;h],
    }
    let mut passed = vec![vec![false; w]; h];
    passed[0][0] = true;
    'outer: for i in 0..h {
        for j in 0..w {
            if i == h - 1 && j == w - 1 {
                break 'outer;
            }
            if a[i][j] == '.' {
                continue;
            }
            if !passed[i][j] {
                println!("Impossible");
                return;
            }
            if i < h - 1 && j < w - 1 {
                if a[i + 1][j] == '#' && a[i][j + 1] != '#' {
                    passed[i + 1][j] = true;
                    continue;
                } else if a[i + 1][j] != '#' && a[i][j + 1] == '#' {
                    passed[i][j + 1] = true;
                    continue;
                } else {
                    println!("Impossible");
                    return;
                }
            } else if i < h - 1 {
                if a[i + 1][j] == '#' {
                    passed[i + 1][j] = true;
                    continue;
                } else {
                    println!("Impossible");
                    return;
                }
            } else if j < w - 1 {
                if a[i][j + 1] == '#' {
                    passed[i][j + 1] = true;
                    continue;
                } else {
                    println!("Impossible");
                    return;
                }
            }
        }
    }
    println!("Possible");
}
