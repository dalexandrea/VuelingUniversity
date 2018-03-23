using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()] //Custom Attribute
    public class CalculadoraIntegrationTests
    {   //I am defining from which Interface to get the methods - ICal.
        ICalculadora iCalculadora = new Calculadora();

        [DataRow(4, 2, 2)]
        [DataRow(6, 3, 2)]
        [DataTestMethod()]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [DataRow(2, 2, 4)]
        [DataRow(1, 2, 2)]
        [DataTestMethod()]
        public void MultiplicationTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplication(num1, num2) == resultado);
        }

        [DataRow(3, 2, 1)]
        [DataRow(4, 2, 2)]
        [DataTestMethod()]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataTestMethod]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}