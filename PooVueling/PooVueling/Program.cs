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
            //use for the string operation choice
            int operation;
            //stock the result of the operation
            double result = 0;

            //Ask user first number
            Console.WriteLine("Type you first number :");
            string stringFirstNumber = Console.ReadLine();
            double num1 = Convert.ToDouble(stringFirstNumber);

            //Ask user second number
            Console.WriteLine("Type you second number :");
            string stringSecondNumber = Console.ReadLine();
            double num2 = Convert.ToDouble(stringSecondNumber);

            //Ask user operation to use
            Console.WriteLine("Enter the operation 1) + 2) - 3) * 4) / ");
            operation = int.Parse(Console.ReadLine());

            
            //Do someting depending on the operation choose
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