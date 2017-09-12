using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Задание10
{
    class Program
    {
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
                x = int.Parse(Console.ReadLine());

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
