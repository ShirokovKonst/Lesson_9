using System;

namespace Lesson_9_homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Prompt("Введите M: ");
            int n = Prompt("Введите N: ");
            Console.WriteLine(Sum(m,n));
            int Prompt(string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }

            int Sum(int m, int n)
            {
                if(m <= n) return m + Sum(m+1,n);
                else return 0;   
            }
        }
    }
}
