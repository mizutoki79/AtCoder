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
        k: usize1,
    }
    let mod_num = 1e9 as i64 + 7;
    let mut pattern = vec![vec![0i64; w]; h];
    for i in (0..h).rev() {
        for j in 0..w {
            if i == h - 1 {
                if j == k {
                    pattern[i][j] = num_pattern(w as i32, j as i32, None);
                } else if (j as i32 - k as i32).abs() == 1 {
                    pattern[i][j] = num_pattern(w as i32, j as i32, Some(k as i32));
                }
            } else {
                pattern[i][j] = num_pattern(w as i32, j as i32, None) * pattern[i + 1][j];
                if j != 0 {
                    pattern[i][j] +=
                        num_pattern(w as i32, j as i32, Some(j as i32 - 1)) * pattern[i + 1][j - 1];
                }
                if j != w - 1 {
                    pattern[i][j] +=
                        num_pattern(w as i32, j as i32, Some(j as i32 + 1)) * pattern[i + 1][j + 1];
                }
            }
            pattern[i][j] %= mod_num;
        }
    }
    if pattern[0][0] == 0 {
        println!("1");
    } else {
        println!("{}", pattern[0][0]);
    }
}

fn num_pattern(w: i32, a: i32, b: Option<i32>) -> i64 {
    if let Some(b) = b {
        count(cmp::min(a, b)) * count(w - cmp::max(a, b) - 1)
    } else {
        count(a) * count(w - a - 1)
    }
}

fn count(num: i32) -> i64 {
    fibonacci(num + 1)
}

fn fibonacci(n: i32) -> i64 {
    if n <= 0 {
        panic!("invalid argument");
    }
    match n {
        1 | 2 => 1,
        3 => 2,
        _ => fibonacci(n - 1) + fibonacci(n - 2),
    }
}
