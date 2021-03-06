﻿using System.Collections.Generic;
using System.Linq;

namespace SimpleWpfApp.Model
{
    public class Prime
    {
        public List<int> GeneratePrimes(int num)
        {
            var ints = Enumerable.Range(2, num-1);
            return ints.Where(x => !ints
                .TakeWhile(y => y < x)
                .Any(y => x % y == 0)).ToList();
        }
    }
}
