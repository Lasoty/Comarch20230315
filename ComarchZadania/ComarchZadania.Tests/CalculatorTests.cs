using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComarchZadania;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchZadania.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        [DataRow(2,3,5)]
        [DataRow(5,10,15)]
        public void AddShouldReturnCorrectSum(int x, int y, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Add(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}