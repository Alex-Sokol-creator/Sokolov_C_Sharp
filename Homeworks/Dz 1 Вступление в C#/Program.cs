using System.Text;

namespace Dz_1_Вступление_в_C_
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            {
            Console.WriteLine("First Task");
            double temperature;
            Console.Write("Enter temperature: ");
            temperature = Convert.ToDouble(Console.ReadLine());
            int choice = 0;
            while (choice != 1 && choice != 2)
            {
                Console.Write("Enter your choice (1 - to Farenheites, 2 - to Celcius): ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            double newTemperature;
            if (choice == 1)
            {
                newTemperature = (temperature * 9 / 5) + 32;
            }
            else
            {
                newTemperature = (temperature - 32) * 5 / 9;
            }
            Console.WriteLine($"Your new temperature will be: {newTemperature}");
            }

            {
                Console.WriteLine("\nSecondTask");
                int num1;
                int num2;
                Console.WriteLine("Введите два числа, чтобы вывести все парные числа в их диапазоне");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < num1)
                {
                    int buffer = num2;
                    num2 = num1;
                    num1 = buffer;
                }
                Console.WriteLine($"Вот все парные числа в диапазоне от {num1} до {num2}:");
                for (int i = num1; i < num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            {
                Console.WriteLine("\nThird Task");
                string num;
                Console.WriteLine("Введите число, чтобы узнать, является ли оно числом Армстронга");
                num = Console.ReadLine();
                int figures_count = num.Length;
                int sum = 0;
                foreach (char figure in num)
                {
                    int current_num = 1;
                    for (int j = 0; j < figures_count; j++)
                    {
                        current_num *= (figure - '0');
                    }
                    sum += current_num;
                }
                int newNum = Convert.ToInt32(num);
                if (newNum == sum)
                {
                    Console.WriteLine("Ваше число является числом Армстронга");
                }
                else
                {
                    Console.WriteLine("Ваше число не является числом Армстронга");
                }
            }
        }
    }
}
