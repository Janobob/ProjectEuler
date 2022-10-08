using System.Diagnostics;

namespace ProgrammRunner
{
    public static class ProgrammRunner<T>
    {
        public static void Run(IProgramm<T> programm)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting Execution");
            
            stopwatch.Start();
            var result = programm.Execute();
            stopwatch.Stop();

            Console.WriteLine("Ending Execution");
            Console.WriteLine($"Result: {result}");

            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
    }
}