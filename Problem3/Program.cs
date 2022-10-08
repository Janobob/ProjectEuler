namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var primes = new List<int>();
            var number = 600851475143;

            for (var div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    Console.WriteLine(div);
                    primes.Add(div);
                    number /= div;
                }
            }
        }
    }
}