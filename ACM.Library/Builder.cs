using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library
{
    public class Builder
    {
        public IEnumerable<int> BuildIntegerSequence()
        {
            var integers = Enumerable.Range(0, 10)
                            .Select(i=> 5+(10 *i));
            return integers;
        }

        public IEnumerable<string> BuildStringSequence()
        {
            var strings = Enumerable.Range(0, 10)
                            .Select(i => ((char)('A' + i)).ToString());

            return strings;
        }

        public IEnumerable<string> BuildStringSequenceRandom()
        {
            Random rand = new Random();
            var strings = Enumerable.Range(0, 10)
                            .Select(i => ((char)('A' + rand.Next(0,26))).ToString());

            return strings;
        }

        public IEnumerable<int> BuildIntegerSequenceUsingRepeat()
        {
            var integers = Enumerable.Repeat(-1,10);
            return integers;
        }
        public IEnumerable<string> BuildStringSequenceUsingRepeat()
        {
            var strings = Enumerable.Repeat("A", 10);
                            //.Select(i => ((char)('A' + i)).ToString());

            return strings;
        }


    }
}
