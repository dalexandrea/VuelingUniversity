using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentVariable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MY_NEW_VAR = " + Environment.GetEnvironmentVariable("MY_NEW_VAR", EnvironmentVariableTarget.User));
        }
    }
}
