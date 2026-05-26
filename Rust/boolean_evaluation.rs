use std::collections::VecDeque;

pub fn	eval_formula(formula: &str) -> bool {
	let mut	i = 0;

	while str[i] && "01!&|^>=".contains(str[i]) {
		i = i + 1;
	}
	if str[i] {
		eprintln!("Invalid character in formula: {}", str[i]);
		return; //
	}

	let mut	booleans = VecDeque::new();

	while str[i] {
		if str[i] == '0' || str[i] == '1' {
			booleans.push_front(str[i] - '0'); //
		} else if "!&|^>=".contains(str[i]) {
			match str[i] {
				'!' => booleans.push_front(
					!(booleans.pop_front())
				);
				'&' => booleans.push_front(
					booleans.pop_front() & booleans.pop_front()
				);
				'|' => booleans.push_front(
					booleans.pop_front() | booleans.pop_front()
				);
				'^' => booleans.push_front(
					booleans.pop_front() ^ booleans.pop_front()
				);
				'>' => ;
				'=' => ;
			};
		i = i + 1;
	}


}