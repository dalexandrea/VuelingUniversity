﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    public class Calculadora : ICalculadora
    {
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}