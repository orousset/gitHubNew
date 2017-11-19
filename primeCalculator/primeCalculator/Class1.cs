using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeCalculator
{
    public class Prime
    {
        bool isPrime(int input) {
            bool result = false;
            for (int cpt = 1; cpt < Math.Sqrt(input); cpt++) {
                if (Math.IEEERemainder(input, cpt) == 0) { result = true; }
            }
            return result;
        }
    }
}
