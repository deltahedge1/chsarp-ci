using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            // Check for divisibility from 2 to the square root of the number
            for (int divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                    return false; // The number is divisible, not prime
            }

            return true; // The number is prime
        }
    }
}
