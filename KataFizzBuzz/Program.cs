using System;

namespace KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("Inserire un numero");
            while(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Inserire un numero");
            }
            var fizzBuzz = new FizzBuzzCounter();
            foreach (var item in fizzBuzz.Counter(input))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
