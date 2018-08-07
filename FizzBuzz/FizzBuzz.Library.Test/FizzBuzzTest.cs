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
        public void Buzzer_WhenDefault_ReturnInput([Values(1,2,4)] int input)
        {
            //int input = 2;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When3_ReturnFizz()
        {
            int input = 3;      // stopped at 15:38

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When5_ReturnFizz()
        {
            int input = 5;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }
    }
}
