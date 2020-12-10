using System;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /// 
            /// Домашняя работа Безукладникова Даниила
            /// 
            /// Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
            /// а) с использованием методов C#;
            /// б) *разработав собственный алгоритм.
            /// Например:
            /// badc являются перестановкой abcd.
            ///

            Console.WriteLine("Программа проверки двух строк на анаграмность");
            Console.WriteLine("Введите первую строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string str2 = Console.ReadLine();
            //с использованием методов C#;
            if (Anagrams.InnerMetods(str1, str2)) Console.WriteLine("Строки являются анаграммами");
            else Console.WriteLine("Строки не являются анаграммами");
            //разработав собственный алгоритм
            if (Anagrams.MyMetod(str1, str2)) Console.WriteLine("Строки являются анаграммами");
            else Console.WriteLine("Строки не являются анаграммами");
            Console.ReadKey();
        }
    }
}
