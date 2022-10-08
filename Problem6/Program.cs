namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1,100);

            var sumOfSquares = numbers.Sum(x => Math.Pow(x, 2));
            var squareOfSum = Math.Pow(numbers.Sum(), 2);

            var result = squareOfSum - sumOfSquares;
            Console.WriteLine(result);
        }
    }
}