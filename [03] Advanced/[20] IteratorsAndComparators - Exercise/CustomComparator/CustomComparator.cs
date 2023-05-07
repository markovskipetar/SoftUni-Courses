using System.Collections.Generic;

namespace CustomComparator
{
    public class CustomComparator : IComparer<int>
    {
        public int Compare(int first, int second)
        {
            int result = 0;

            bool areBothEven = first % 2 == 0 && second % 2 == 0;
            bool areBothOdd = first % 2 != 0 && second % 2 != 0;

            if (areBothEven || areBothOdd)
            {
                result = first - second;
            }
            else
            {
                if (first % 2 == 0)
                {
                    result = -1;
                }
                else if (second % 2 == 0)
                {
                    result = 1;
                }
            }

            return result;
        }
    }
}
