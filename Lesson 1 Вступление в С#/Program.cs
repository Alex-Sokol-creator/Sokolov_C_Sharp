using System.Text;

namespace Lesson_1_Вступление_в_С_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            /*
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello, World!");

            Console.WriteLine("I love .NET");

            Console.Write("First");
            Console.Write("Second");
            */

            byte b;

            //Console.WriteLine(b);

            short s = 0;
            // int i = 0;
            long l = 0;

            uint ui = 0;

            float f = 0.0f;
            double d = 0.0;

            bool logic = false; // false
            Console.WriteLine(logic);
            char c = 'g';

            string str = null;

            string fullName = "Anton Antonovych";

            Console.WriteLine(str);

            //int input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(input);

            string text = Console.ReadLine();
            Console.WriteLine(text);

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can enter");
            }
            else
            {
                Console.WriteLine("You cannot enter, because your age is lower than 18 years old");
            }

            string input = Console.ReadLine();

            string name = input == null ? "guest" : input;

            string month = "Jan";

            switch (month)
            {
                case "Jan": Console.WriteLine("January"); break;
                case "Feb": Console.WriteLine("February"); break;
                default: Console.WriteLine("Some month"); break;
            }

            int counter = 0;
            while (counter < 20)
            {
                Console.WriteLine(counter++);
            }

            counter = 0;
            do
            {
                Console.WriteLine(counter++);
            } while (counter < 20);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(counter++);
            }
        }
    }
}
