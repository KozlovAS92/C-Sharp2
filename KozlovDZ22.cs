using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozlovDZ22
{
    class Class
    {
        public void Metod1(int x)
        {
            int i = 0;
            int b = 1;
            if (x != 0)
            {
                do
                {
                    i = x / Convert.ToInt32(Math.Pow(10, b));
                    b++;
                }
                while (i != 1);
            }
            Console.WriteLine($"\nКолличество цифр в числе: {b}");
        }
    }
    class KozlovDZ22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение задачи 2\nВведите целое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Class CL = new Class();
            CL.Metod1(a);
            Console.ReadKey();
        }
    }
}
