using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozlovDZ23
{
    class KozlovDZ23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение задач 3:\nВведите число. Числа вводятся до тех пор, пока не будет введен 0.");
            int a = 0;
            int b = 0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) { break; }
                else if ((a > 0)&((a%2)!=0)) { b = b + a; }
            }
            while (a!=0);
            Console.WriteLine($"\nСумма всех нечетных положительных чисел равна: {b}");
            Console.ReadKey();
        }
    }
}
