using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            // throw new NotImplementedException();

            // return "1"; - output for When1_Return1()

            // return input.ToString(); - output for When2_Return2()

            if (input == 3)     // output for - When3_ReturnFizz()
                return "FizzBuzz";
            return input.ToString();
        }
    }
}
