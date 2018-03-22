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
            Console.WriteLine(Environment.GetEnvironmentVariable("MyFirstEV"));
            Console.ReadKey();
        }
    }
}
