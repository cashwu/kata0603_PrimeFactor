using System.Collections.Generic;

namespace kata0603_PrimeFactor
{
    internal class PrimeFactor
    {
        public int[] GetPrimeFactor(int number)
        {
            var result = new List<int>();

            for (int i = 2; number != 1; i ++)
            {
                for( ; number % i == 0 ; )
                {
                    number /= i;
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
    }
}