using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit_Tester
{
    class RPNCalculatorTests
    {
        [Test]
        public void TestSingleDigit()
        {
            RPNCalculater calc = new RPNCalculater();
            Assert.That(calc.Evaluate("3"), Is.EqualTo(3));
        }
        [Test]
        public void TestSingleDigit2()
        {
            RPNCalculater calc = new RPNCalculater();
            Assert.That(calc.Evaluate("4"), Is.EqualTo(4));
        }
        [Test]
        public void TestSingleDigit3()
        {
            RPNCalculater calc = new RPNCalculater();
            Assert.That(calc.Evaluate("5"), Is.EqualTo(5));
        }
    }
}
