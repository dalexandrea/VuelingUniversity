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

        [TestMethod()]
        public void DivisionTest()
        {
            Assert.IsTrue(iCalculadora.Division(4,2)==2);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Assert.IsTrue(iCalculadora.Multiplication(2,2)== 4);
        }

        [TestMethod()]
        public void RestaTest()
        {
           Assert.IsTrue(iCalculadora.Resta(3, 1) == 2);
        }

        [TestMethod()]
        public void SumaTest()
        {
            Assert.IsTrue(iCalculadora.Suma(2, 2) == 4);
            //Assert.Fail();
        }
    }
}