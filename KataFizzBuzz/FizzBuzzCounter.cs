using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzz
{
    public class FizzBuzzCounter : IFizzBuzzCounter
    {
        public List<string> Counter(int input)
        {
            var result = new List<string>();
            for (int i = 1; i <= input; i++)
            {
                result.Add(Translate(i));
            }
            return result;
        }

        public string Translate(int input)
        {
            if (input <= 0) throw new ArgumentException("The input must be greater than 0");
            else if (input % 3 == 0 && input % 5 == 0) return "FizzBuzz";
            else if (input % 3 == 0) return "Fizz";
            else if (input % 5 == 0) return "Buzz";
            else return input.ToString();
        }
    }
}
