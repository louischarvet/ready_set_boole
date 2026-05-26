namespace ReadySetBoole
{
    public static class Adder
    {
        public static uint Add(uint a, uint b)
        {
            uint result = a ^ b;
            uint carry = (a & b) << 1;

            while (carry != 0)
            {
                uint previousResult = result;
                result = result ^ carry;
                carry = (previousResult & carry) << 1;
            }
            return result;
        }
    }
}