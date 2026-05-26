pub fn	gray_code(n: u32) -> u32 {
	let mut	result = 0;
	let mut	i = 31;

	if n == 0 || n == 1 {
		return n;
	}
	while i >= 0 && n >> i & 1 == 0 {
		i = i - 1;
	}
	let mut	previous_bit = 1;
	result |= previous_bit << i;
	i = i - 1;
	while i >= 0 {
		result |= ((n >> i & 1) ^ previous_bit) << i;
		previous_bit = n >> i & 1;
		i = i - 1;
	}
	return result;
}