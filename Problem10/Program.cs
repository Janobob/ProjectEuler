using ProgrammRunner;

namespace Problem10
{
    internal class Program : IProgramm<long>
    {
        static void Main(string[] args)
        {
            ProgrammRunner<long>.Run(new Program());
        }

        public long Execute()
        {
            long max = 2000000;
            long sum = 0;

            for(long i = 2; i < max; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            
            return sum;
        }

        public bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}