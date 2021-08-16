using System;

namespace Tehtävä_5
{
    class Exercise
    {
        public Exercise()
        {
            Console.WriteLine("Default message\n");
        }
        public Exercise(string msg)
        {
            Console.Write("Give me message: ");
            msg = Console.ReadLine();
            Console.WriteLine("Your message: " + msg);
        }
        public Exercise(int num1, int num2)
        {
            Console.WriteLine("\nGive me two numbers and I'll add them");
            Console.Write("1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise def = new Exercise();
            Exercise msg = new Exercise("msg");
            Exercise add = new Exercise(1,1);
            Console.ReadKey();
        }
    }
}
