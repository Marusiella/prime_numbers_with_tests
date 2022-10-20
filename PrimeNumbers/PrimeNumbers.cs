using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public int Start { get; set; }
        public int End { get; set; }
        public List<int> Primes { get; set; }

        public PrimeNumbers()
        {
            Start = 2;
            End = 10;
            Primes = new List<int>();
        }
        public PrimeNumbers(int start, int end)
        {
            if (start >= 2)
            {
                Start = start;
            }
             else
            {
                Start = 2;
            }
            End = end;
            Primes = new List<int>();
        }
        private bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public List<int> GetNumbers()
        {
            for (var i = Start; i <= End; i++)
            {
                if (IsPrime(i))
                {
                    Primes.Add(i);
                }
            }
            return Primes;
        }
    }
}
