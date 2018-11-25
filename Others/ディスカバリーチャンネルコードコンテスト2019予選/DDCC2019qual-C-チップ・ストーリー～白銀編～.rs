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
    }
    let mod_num = 1e9 as usize + 7;
    let sqrt_n = (n as f64).sqrt().floor() as usize;
    let mut result = 0;
    for max_p in 1..sqrt_n + 1 {
        let max_q = (sqrt_n..n + 1).filter(|x| max_p * x <= n).last().unwrap();
        // eprintln!("max_p: {}, max_q: {} , {}", max_p, max_q, max_p * max_q);
        result += mod_pow(max_p, 10, mod_num) * mod_pow(max_q, 10, mod_num) * 2 % mod_num;
        result -= mod_pow(cmp::min(max_p, max_q), 10, mod_num);
        result %= mod_num;
    }
    println!("{}", result)
}

fn mod_pow(value: usize, power: u32, divisor: usize) -> usize {
    if power == 0 {
        1usize
    } else if power % 2 == 0 {
        let half_power = power / 2;
        let half_result = mod_pow(value, half_power, divisor);
        half_result * half_result % divisor
    } else {
        value * mod_pow(value, power - 1, divisor) % divisor
    }
}
