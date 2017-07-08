using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, z;
            Console.WriteLine("Введите три различных числа: ");
            x = Convert.ToSingle(Console.ReadLine());
            y = Convert.ToSingle(Console.ReadLine());
            z = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Результирующая последовательность: ");
            if ((x != y) & (y != z) & (x != z))
            {
                if (x + y + z < 1)
                {
                    if ((x < y) & (x < z))
                        x = (y + z) / 2;
                    else
                    if (y < z)
                        y = (x + z) / 2;
                    else z = (x + y) / 2;
                }
                else
                if (x < y)
                    x = (y + z) / 2;
                else y = (x + z) / 2;
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
            }
            else Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}