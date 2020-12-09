using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrLog
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /// 
            /// Домашняя работа Безукладникова Даниила
            /// Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
            /// содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            /// а) без использования регулярных выражений;
            /// б) с использованием регулярных выражений.
            ///
            Console.WriteLine("Программа для проверки логина");
            Console.WriteLine("Введите логин, он должен быть от 2 до 10 символов, содержать только буквы латинского алфавита или цифры, и цифра не может быть первой:");
            string login = Console.ReadLine();
            //без использования регулярных выражений
            if (CheckLogin.Check(login)) Console.WriteLine("Введенный логин соответсвует условиям");
            else Console.WriteLine("Введенный не логин соответсвует условиям");
            /// с использованием регулярных выражений.
            if (CheckLogin.RegCheck(login)) Console.WriteLine("Введенный логин соответсвует условиям");
            else Console.WriteLine("Введенный не логин соответсвует условиям");

            Console.ReadKey();
            
        }
    }
}
