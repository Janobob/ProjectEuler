﻿using ProgrammRunner;

namespace $safeprojectname$
{
    internal class Program : IProgramm<int>
    {
        static void Main(string[] args)
        {
            ProgrammRunner<int>.Run(new Program());
        }

        public int Execute()
        {
            return 0;
        }
    }
}