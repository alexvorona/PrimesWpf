using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWpfApp.Model
{
    public class Prime
    {
        public List<int> GeneratePrimes(int num)
        {
            var ints = Enumerable.Range(2, num);
            return ints.Where(x => !ints
                .TakeWhile(y => y < x)
                .Any(y => x % y == 0)).ToList();
        }
    }
}
