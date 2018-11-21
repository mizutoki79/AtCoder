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
    let mut remove_h_idxes = HashSet::new();
    for (i, chars) in a.iter().enumerate() {
        if !chars.contains(&'#') {
            remove_h_idxes.insert(i);
        }
    }
    let mut remove_v_idxes = HashSet::new();
    for j in 0..w {
        remove_v_idxes.insert(j);
        for i in 0..h {
            if a[i][j] == '#' {
                remove_v_idxes.remove(&j);
            }
        }
    }
    let mut new_a = Vec::new();
    for i in 0..h {
        if remove_h_idxes.contains(&i) {
            continue;
        }
        new_a.push(Vec::new());
        for j in 0..w {
            if remove_v_idxes.contains(&j) {
                continue;
            }
            new_a.last_mut().unwrap().push(a[i][j]);
        }
    }
    for line in new_a {
        for ch in line {
            print!("{}", ch);
        }
        println!();
    }
}
