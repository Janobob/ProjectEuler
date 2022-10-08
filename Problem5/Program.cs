namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var divideUntil = 20;
            var currentProduct = 0;
            var found = false;

            while(!found)
            {
                currentProduct += 2;
                var positiveRun = true;

                for (var i = 1; i <= divideUntil; i++)
                {
                    if(currentProduct % i != 0)
                    {
                        positiveRun = false;
                        break;
                    }
                }

                found = positiveRun;
            }

            Console.WriteLine(currentProduct);
        }
    }
}