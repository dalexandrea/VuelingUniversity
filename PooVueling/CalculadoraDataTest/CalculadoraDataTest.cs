using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDataTest
{
    public class CalculadoraDataTest
    {
        ICalculadora iCalculadora = new Calculadora();

        [DataRow(2,2,2)]
        [DataRow(3,3,6)]
        [DataTestMethod]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1,num2) == resultado);
        }

        
    }
}
