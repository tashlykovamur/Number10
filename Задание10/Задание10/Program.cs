using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Задание10
{
    class Program
    {
        static int InputX(int left, int right)//ввод x 
        { bool ok = false;
            int number = -100;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number >= left && number < right) ok = true;
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                        ok = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка ввода");
                    ok = false;
                }
            } while (!ok);
            return number;
        }

        static void Main(string[] args)
        {
            Polinom polinom = new Polinom();

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (sr.Peek() != -1)
                {
                    var arr = sr.ReadLine().Split();
                    int step = int.Parse(arr[0]);
                    int koef = int.Parse(arr[1]);

                    polinom.Add(step, koef);
                }
            }

            polinom.Show();

            int x = 0;

            do
            {
                Console.WriteLine("Введите x (для выхода введите 0)");
                x = InputX(-100, 100);
                if (x != 0)
                {
                    int res = polinom.Calc(x);

                    Console.WriteLine(res);
                }
            }
            while (x != 0);
        }
    }
}
