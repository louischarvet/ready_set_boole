use std::collections::VecDeque;

pub fn	eval_formula(formula: &str) -> bool {
	let mut	i: usize = 0;

	// Check
	for c in formula.chars() {
		if !"01!&|^>=".contains(c) {
			eprintln!("Invalid character in formula: {}", c);
			return false; //
		}
	}

	let mut	booleans = VecDeque::< bool >::new();

	for c in formula.chars() {
		if c == '0' || c == '1' {
			booleans.push_front(c == '1');
		} else if "!&|^>=".contains(c) {
			if let Some(b1) = booleans.pop_front() {
				match c {
					'!' => booleans.push_front(!b1),
					'&' | '|' | '^' | '>' | '=' => {
						if let Some(b2) = booleans.pop_front() {
							booleans.push_front(match c {
								'&' => b1 && b2,
								'|' => b1 || b2,
								'^' => b1 != b2,
								'>' => !b1 || b2,
								'=' => b1 == b2,
								_ => false /////////////////
							});
						} else {
							eprintln!("Syntax error at: {}", c);
						}
					},
					_ => {} /////////////////////////
				};
			} else {
				eprintln!("Syntax error at: {}", c);
			}
		}
		i = i + 1;
	}

	if let Some(result) = booleans.pop_front() {
		return result;
	} else {
		eprintln!("Error");
		return false;
	}
}