using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammRunner
{
    public interface IProgramm<T>
    {
        T Execute();
    }
}
