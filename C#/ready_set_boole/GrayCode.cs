namespace ReadySetBoole
{
	public static class GrayCode
	{
		public static uint ToGray(uint n)
		{
			uint result = 0;
			if (n <= 1)
				return n;
			
			int i = 31;
			while (i >= 0 && n >> i == 0)
				i--;
			uint previousBit = 1;
			result |= previousBit << i;
			i--;
			while (i >= 0)
			{
				result |= ((n >> i & 1) ^ previousBit) << i;
				previousBit = n >> i & 1;
				i--;
			}
			return result;
		}
	}
}