using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public Lake(int[] rocks)
        {
            this.rocks = rocks;
        }

        private int[] rocks;

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.rocks.Length; i += 2)
            {
                yield return this.rocks[i];
            }

            int lastIndex = this.rocks.Length % 2 == 1 ? this.rocks.Length - 2 : this.rocks.Length-1;

            for (int i = lastIndex; i >= 0; i -= 2)
            {
                yield return this.rocks[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
