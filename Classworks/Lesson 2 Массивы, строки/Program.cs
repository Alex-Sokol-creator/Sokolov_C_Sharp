using System.Text;

namespace Lesson_2_Массивы__строки
{

    enum Status
    {
        Online,Offline,Unknown
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 15, 56, 23 };
            //int[] numbers2 = new int[6] { 10, 15, 12, 3, 556, 0 };

            //Console.WriteLine(numbers2[0]);

            // object obj = null;

            // Console.WriteLine(obj.ToString());

            /*

            int[] numbers = { 10, 5, 556, 2 };

            Console.WriteLine(numbers.Length);

            Console.WriteLine(numbers[0].ToString());
            Console.WriteLine(numbers.ToString());

            // Console.WriteLine(numbers[150]);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            object[] objects = { 1, 6.8, true, 'c', "text" };
            */

            /*
            int[,] arr2d =
            {
                {1,2,3, },
                {1,2,3, }
            };

            int[,,] arr3d = new int[1,1,3]
            {
                {
                    {1,2,3 },
                }
            };

            Console.WriteLine(arr2d[0, 2]);

            Console.WriteLine(arr2d.Rank);
            Console.WriteLine(arr2d.Length);
            Console.WriteLine(arr2d.GetLength(0));
            */

            /*
            int[] numbers = { 10, 12, 13, 56, 67, 1, 2, 3, 2 };
            Array.Sort(numbers);

            int index = Array.BinarySearch(numbers, 2);

            Console.WriteLine(index);

            foreach(int number in numbers)
            {
                Console.WriteLine($"{number}");
            }
            Console.WriteLine();

            Array.Reverse(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");
            }
            Console.WriteLine();

            Array.Clear(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");
            }
            Console.WriteLine();

            int[] copy = new int[9];
            numbers.CopyTo(copy,0);

            copy[0] = -5;

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");
            }*/

            /*
            int[] numbers = { 10, 12, 13, 56, 67, 1, 2, 3, 2 };

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Contains(56));
            */

            //string str1 = null;
            // string str = "Hello world";

            // string str = new string('c', 10);

            // Console.WriteLine(str[5]);

            // str[1] = '1';

            //str.Remove();
            // str = str.Replace('H', 'D');

            /*
            string str = "hello" + " " + "world!";
            Console.WriteLine(str);

            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Insert(5, "SUBSTR"));

            string[] words = str.Split(' ');

            Console.WriteLine(words.Length);

            int[] numbers = { 10, 12, 13, 56, 67, 1, 2, 3, 2 };

            string numberStr = string.Join(", ", numbers);
            Console.WriteLine(numberStr);
            */

            //string str = "             Hello!           ";     
            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str.TrimStart());
            //Console.WriteLine(str.TrimEnd());

            StringBuilder sb = new StringBuilder();

            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.MaxCapacity);

            sb.Append("hello");
            sb.Append(" world");
            sb.Append("\nI love C++");
            sb.Append("\nI love C#");
                
            string str = sb.ToString();

            Status userStatus = Status.Online;
            string[] statusEnum = Enum.GetNames(typeof(Status));

            foreach (string statusEnumItem in statusEnum) 
            {
                Console.WriteLine(statusEnumItem);
            }
        }
    }
}
