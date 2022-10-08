namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentNumber = 1;
            var lastPrime = 1;
            var indexOfPrime = 0;

            while (indexOfPrime < 10001)
            {
                if (IsPrime(currentNumber))
                {
                    lastPrime = currentNumber;
                    indexOfPrime++;
                }

                currentNumber += 2;
            }

            Console.WriteLine(lastPrime);
        }

        public static bool IsPrime(int number)
        {
            for (int counter = number - 1; counter > 1; counter--)
            {
                // cast the number to a float to prevent a wrong result from the division
                float divide = (float)number / counter;
                if (divide % 1 == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}