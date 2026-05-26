namespace ReadySetBoole
{
	public delegate bool	Operate(bool a, bool b);
	public static class EvalFormula
	{
		private const string	booleans = "01";
		private const string	operators = "&|^>=";

		private static bool	Negation(bool a)
		{
			return !a;
		}

		private static bool	Conjunction(bool a, bool b)
		{
			return a && b;
		}
		private static bool	Disjunction(bool a, bool b)
		{
			return a || b;
		}
		private static bool	ExclusiveDisjunction(bool a, bool b)
		{
			return a != b;
		}
		private static bool	MaterialCondition(bool a, bool b)
		{
			return !a || b;
		}
		private static bool	LogicalEquivalence(bool a, bool b)
		{
			return a == b;
		}

		private static Operate[]	operate = new Operate[]
		{
			Conjunction,
			Disjunction,
			ExclusiveDisjunction,
			MaterialCondition,
			LogicalEquivalence
		};

		public static bool Evaluate(string formula)
		{
			try
			{
				Stack< bool >	stack = new Stack< bool >(formula.Length);

				foreach (char c in formula)
				{
					Console.WriteLine("c = " + c);

					if (booleans.IndexOf(c) >= 0)
						stack.Push(c == '1');
					else if (c == '!')
						stack.Push(Negation(stack.Pop()));
					else
					{
						int	index = operators.IndexOf(c);
						if (index >= 0)
						{
							bool b = stack.Pop();
							stack.Push(operate[index](stack.Pop(), b));
						}
						else
							throw new Exception(
								"Invalid character: " + c); // StringBuilder
					}
				}
				return stack.Pop();
			} catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
				return false;
			}
		}
	}
}