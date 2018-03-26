using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora iCalculadora = new Calculadora();
            int operation;
            int result = 0;

            Console.WriteLine("Type you first number :");
            string stringnum1 = Console.ReadLine();
            int num1 = Convert.ToInt32(stringnum1);

            Console.WriteLine("Type you second number :");
            string stringnum2 = Console.ReadLine();
            int num2 = Convert.ToInt32(stringnum2);

            Console.WriteLine("Enter the operation 1) + 2) - 3) * 4) / ");
            operation = int.Parse(Console.ReadLine());

            
            switch (operation)
            {
                case 1:
                    result = iCalculadora.Suma(num1, num2);
                    break;

                case 2:
                    result = iCalculadora.Resta(num1, num2);
                    break;

                case 3:
                    result = iCalculadora.Multiplication(num1, num2);
                    break;

                case 4:
                    result = iCalculadora.Division(num1, num2);
                    break;

            }
            Console.WriteLine("\nResult " + result );
            Console.ReadKey();
        }
    }
}