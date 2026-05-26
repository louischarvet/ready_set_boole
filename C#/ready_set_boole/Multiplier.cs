namespace ReadySetBoole
{
	public static class Multiplier
	{
		public static uint Multiply(uint a, uint b)
		{
			uint n, toAdd;
			if (a < b)
			{
				n = a;
				toAdd = b; 
			}
			else
			{
				n = b;
				toAdd = a;
			}

			uint result = 0;
			for (uint i = 0; i < n; i++)
				result = Adder.Add(result, toAdd);
			return result;
		}
	}
}