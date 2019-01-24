using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozlovDZ24
{
    class Class
    {
        string Login = "root";
        string Password = "GeekBrains";
        public bool metod1 (string a, string b)
        {
            if ((Login == a) && (Password == b)) { return (true); }
            else { return (false); }
        }
    }
    class KozlovDZ24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение задачи 4:");
            string LoginIN = "";
            string PasswordIN = "";
            Class CL = new Class();
            int i = 0;
            bool Enter = false;
            do
            {
                Console.WriteLine("\nВведите логин: ");
                LoginIN = Console.ReadLine();
                Console.WriteLine("\nВведите пароль: ");
                PasswordIN = Console.ReadLine();
                if (CL.metod1(LoginIN, PasswordIN)==true) { Enter = true; Console.WriteLine("\nДобро пожаловать!"); break; }
                else { Console.WriteLine("\nНеверный логин или пароль, попробуйте еще раз."); i++; }
            }
            while (i != 3);
            if (i == 3) { Console.WriteLine("\nКолличество попыток 3. Попробуйте позже"); }
            Console.ReadKey();
        }
    }
}
