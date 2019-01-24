using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozlovDZ21
{
    public class Class
    {
        public int Metod1(int d, int e, int g)
        {
            if ((d < e) && (d < g)) { return d; }
            else if ((e < d) && (e < g)) { return e; }
            else { return g; }
            /*int k;
            int[] num = { d, e, g };
            for (int i = 0; i < (num.Length -1); i++) { if (num[i] < num[i + 1]) { k = num[i]; } };
            return k;*/
        }
    }
    class KozlovDZ21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение задачи 1:");
            Console.WriteLine("\nПоследовательно введите три целых числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Class CL = new Class();
            Console.WriteLine($"Наименьшее число: {CL.Metod1(a, b, c)}");
            Console.ReadKey();
        }
    }
}
