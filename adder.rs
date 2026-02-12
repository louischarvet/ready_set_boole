pub fn	adder(a: u32, b: u32) -> u32 {
	let mut	result = a ^ b;
	let mut	carry = (a & b) << 1;

	while carry != 0 {
		let	prv_result = result;
		result = result ^ carry;
		carry = (prv_result & carry) << 1;
	}
	return result;
}
