using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    public class Program : Calculadora
    {
        static void Main(string[] args)
        {   //guardar eleccion
            int operation = 0;
            //guardar el resultado de la eleccion
            double result = 0;

            //pide number 1
            Console.WriteLine("Elegir primer numero");
            string stringFirstNumber = Console.ReadLine();
            double firstNumber = Convert.ToDouble(stringFirstNumber);

            //pide number 2
            Console.WriteLine("Elegir segundo numero");
            string stringSecondNumber = Console.ReadLine();
            double secondNumber = Convert.ToDouble(stringSecondNumber);

            //lista opciones y preguntar eleccion
            Console.WriteLine("Elegir entre 1 +,2 -,3 *,4 /,5 exit ");
            string stringOperation = Console.ReadLine();
            Int32.TryParse(stringOperation.Text, out operation);

            switch (operation)
            {
                case 1:
                    result = Suma(firstNumber, secondNumber);
                    break;

                case 2:
                    result = Resta(firstNumber, secondNumber);
                    break;

                case 3:
                    result = Multiplication(firstNumber, secondNumber);
                    break;

                case 4:
                    result = Division(firstNumber, secondNumber);
                    break;
                case 5:
                    break;

            }
            Console.WriteLine("Result" + result);
            Console.ReadKey();
        }
    }
}
