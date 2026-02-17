mod eval_formula;

use std::env;
use eval_formula::eval_formula;

fn	main() {
	let	args: Vec< String > = env::args().collect();
	if args.len() != 2 {
		eprintln!("Usage: ./main <formula>");
		std::process::exit(1);
	}

	println!("{}", eval_formula(args[1].as_str()));
}