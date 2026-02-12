use adder::adder;

pub fn multiplier(a: u32, b: u32) -> u32 {
	let	n;
	let	to_add;

	if a < b {
		n = a;
		to_add = b;
	} else {
		n = b;
		to_add = a;
	}

	let mut	result = 0;
	let mut	i = 0;
	while i < n {
		result = adder(result, to_add);
		i = i + 1;
	}
	return result;
}
