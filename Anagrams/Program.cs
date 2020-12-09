using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        class Anagrams
        {
           public static bool InnerMetods(string str1, string str2)
           {
                return String.Equals(String.Concat(str1.OrderBy(a => a)), String.Concat(str2.OrderBy(a => a)));
           }
            public static bool MyMetod(string str1, string str2)
            {
                if (str1.Length == str2.Length)
                {
                    var uniq = str1.ToCharArray().Distinct();
                    Dictionary<char, int> letters = new Dictionary<char, int>();
                    foreach (var ch in uniq)
                    {
                        letters.Add(ch, str1.Count(c => c == ch));
                    }
                    uniq = str2.ToCharArray().Distinct();
                    foreach (var ch in uniq)
                    {
                        KeyValuePair<char, int> pair = new KeyValuePair<char, int>(ch,str1.Count(c => c == ch));
                        if (!letters.Contains(pair))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else return false;
            }

        }
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
            Console.WriteLine("Первую строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Вторую строку:");
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
