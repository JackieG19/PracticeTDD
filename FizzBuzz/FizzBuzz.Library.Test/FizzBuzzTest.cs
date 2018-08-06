using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Buzzer_When1_Return1()
        {
            int input = 1;  // Arrange

            string output = FizzBuzzer.GetValue(input); // Act

            Assert.AreEqual("1", output);   // Assert
        }

        [Test]
        public void Buzzer_When2_Return2()
        {
            int input = 2;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("2", output);
        }

        [Test]
        public void Buzzer_When3_ReturnFizz()
        {
            int input = 3;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }
    }
}
