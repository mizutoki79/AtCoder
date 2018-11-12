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
