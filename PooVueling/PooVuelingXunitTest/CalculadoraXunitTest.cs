using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PooVuelingXunitTest
{
    public class CalculadoraXunitTest
    {
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(4, iCalculadora.Suma(2, 2));
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(2, iCalculadora.Division(4, 2));
        }

        [Fact]
        public void MultiplicationTest()
        {
            Assert.Equal(4, iCalculadora.Multiplication(2, 2));
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(2, iCalculadora.Resta(3, 1));
        }
    }
}
