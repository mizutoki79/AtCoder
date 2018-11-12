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
        s: chars,
    }
    let mut r_count_table = [('A', 0), ('B', 0), ('C', 0), ('?', 0)]
        .iter()
        .cloned()
        .collect::<HashMap<char, usize>>();
    let mut l_count_table = r_count_table.clone();
    for ch in s.iter() {
        if let Some(cnt) = r_count_table.get_mut(&ch) {
            *cnt += 1;
        }
    }

    // eprintln!("r");
    // for item in r_count_table.iter() {
    //     eprintln!("{}: {}", item.0, item.1);
    // }
    // eprintln!("l");
    // for item in l_count_table.iter() {
    //     eprintln!("{}: {}", item.0, item.1);
    // }

    let divisor = 1e9 as usize + 7;
    let mut total_count = 0;
    for &ch in s.iter() {
        match ch {
            'A' | 'C' => {
                if let Some(cnt) = r_count_table.get_mut(&ch) {
                    *cnt -= 1;
                }
                if let Some(cnt) = l_count_table.get_mut(&ch) {
                    *cnt += 1;
                }
                // eprintln!("r");
                // for item in r_count_table.iter() {
                //     eprintln!("{}: {}", item.0, item.1);
                // }
                // eprintln!("l");
                // for item in l_count_table.iter() {
                //     eprintln!("{}: {}", item.0, item.1);
                // }
            }
            'B' | '?' => {
                if let Some(cnt) = r_count_table.get_mut(&ch) {
                    *cnt -= 1;
                }
                // eprintln!("r");
                // for item in r_count_table.iter() {
                //     eprintln!("{}: {}", item.0, item.1);
                // }
                // eprintln!("l");
                // for item in l_count_table.iter() {
                //     eprintln!("{}: {}", item.0, item.1);
                // }
                let power = l_count_table[&'?'];
                let power1 = if power > 0 { power - 1 } else { 0 };
                let l_current_count = l_count_table[&'A'] * mod_pow(3, power as u32, divisor)
                    % divisor
                    + power * mod_pow(3, power1 as u32, divisor) % divisor;
                let power = r_count_table[&'?'];
                let power1 = if power > 0 { power - 1 } else { 0 };
                let r_current_count = r_count_table[&'C'] * mod_pow(3, power as u32, divisor)
                    % divisor
                    + power * mod_pow(3, power1 as u32, divisor) % divisor;
                // eprintln!("lcurr: {}", l_current_count);
                // eprintln!("rcurr: {}", r_current_count);
                total_count += (l_current_count % divisor) * (r_current_count % divisor);
                total_count %= divisor;
                if let Some(cnt) = l_count_table.get_mut(&ch) {
                    *cnt += 1;
                }
                // eprintln!("total_count: {}", total_count);
            }
            _ => panic!("invalid character"),
        }
    }
    println!("{}", total_count);
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
