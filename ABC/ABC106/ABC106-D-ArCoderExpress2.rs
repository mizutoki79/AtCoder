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
        lr: [(usize1, usize1);m],
        pq: [(usize1, usize1);q],
    }
    let mut l_list = vec![HashSet::new(); n];
    let mut r_list = vec![HashSet::new(); n];
    for (i, &(l, r)) in lr.iter().enumerate() {
        // eprintln!("{} {} {}", i, l, r);
        for j in 0..l + 1 {
            l_list[j].insert(i);
            // eprintln!("list[{}]: {:?}", j, l_list[j]);
        }
        for j in r..n {
            r_list[j].insert(i);
            // eprintln!("list[{}]: {:?}", j, r_list[j]);
        }
    }
    for (p, q) in pq {
        //     eprintln!("{} {}", p, q);
        //     eprintln!("{:?} {:?}", l_list[p], r_list[q]);
        let result = l_list[p].intersection(&r_list[q]);
        // for x in result {
        //     eprint!("{} ", x);
        // }
        // eprintln!();
        println!("{}", result.into_iter().count());
    }
}
