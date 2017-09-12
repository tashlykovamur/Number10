using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание10
{
    public class Polinom
    {
        class ListItem
        {
            public int Stepen { get; set; }
            public int Koefficient { get; set; }
            public ListItem Next { get; set; }
        }

        private ListItem first;

        private ListItem last;

        public void Add(int stepen, int koef)
        {
            if (koef == 0)
                return;

            ListItem li = new ListItem();
            li.Stepen = stepen;
            li.Koefficient = koef;

            if (first == null)
            {
                first = li;
                last = li;
            }
            else
            {
                last.Next = li;
                last = li;
            }
        }

        public void Show()
        {
            ListItem beg = first;

            Console.Write("P(x) = ");
            while (beg != null)
            {
                Console.Write($"{beg.Koefficient}*x^{beg.Stepen}");

                if (beg.Next != null && beg.Next.Koefficient > 0)
                    Console.Write("+");

                beg = beg.Next;
            }

            Console.WriteLine();
        }

        public int Calc(int x)
        {
            ListItem beg = first;

            int res = 0;

            while (beg != null)
            {
                res += (int)(beg.Koefficient * Math.Pow(x, beg.Stepen));

                beg = beg.Next;
            }

            return res;
        }
    }
}

