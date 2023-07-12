using System;

namespace Lesson_9_homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Prompt("Введите М: ");
            int n = Prompt("Введите N: ");
            Console.WriteLine(Akkerman(m,n));
            int Prompt (string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }

            int Akkerman(int m, int n)
            {
                if(m == 0)
                {
                    return n + 1;
                }
                else 
                {
                    if((m != 0) && (n == 0))
                        return Akkerman(m-1,1);
                    else
                        return Akkerman(m-1, Akkerman(m,n-1));
                }
            }
        }
    }
}
