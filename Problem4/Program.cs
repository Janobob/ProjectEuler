namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largestPalindrome = 0;

            for(int multiplicand = 999; multiplicand > 0; multiplicand--)
            {
                for(int multiplicator = 999; multiplicator > 0; multiplicator--)
                {
                    var product = multiplicand * multiplicator;
                    var productString = product.ToString();
                    var firstPart = string.Concat(productString.Take(3));
                    var secondPart = string.Concat(productString.Skip(3).Take(3).Reverse());

                    if (firstPart == secondPart && largestPalindrome < product)
                    {
                        largestPalindrome = product;
                    }
                }
            }

            Console.WriteLine(largestPalindrome);
        }
    }
}