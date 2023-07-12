using System;

namespace Lesson_9_homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Prompt("Введите число: ");
            string result = ReverseCount(num);
            Console.WriteLine(result.Remove(result.Length-1));

            int Prompt(string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }

            string ReverseCount(int i)
            {
                if (i > 0) return i.ToString() + "," + ReverseCount(i-1);
                else return String.Empty;
            }
        }
    }
}
