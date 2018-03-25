using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{

    public interface ICalculadora
    {
        double Suma(double num1, double num2);
        double Resta(double num1, double num2);
        double Multiplication(double num1, double num2);
        double Division(double num1, double num2);
    }
}
