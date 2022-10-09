using ProgrammRunner;

namespace Problem9
{
    internal class Program : IProgramm<int>
    {
        static void Main(string[] args)
        {
            ProgrammRunner<int>.Run(new Program());
        }

        public int Execute()
        {
            var a = 0;
            var b = 0;
            var c = 0;
            var s = 1000;
            var found = false;
            for (a = 1; a < s / 3; a++)
            {
                for (b = a; b < s / 2; b++)
                {
                    c = s - a - b;

                    if (a * a + b * b == c * c)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }
            return a * b * c;
        }
    }
}