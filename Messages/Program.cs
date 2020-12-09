using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /// 
            /// Домашняя работа Безукладникова Даниила
            /// 
            /// Разработать класс Message, содержащий следующие статические методы для обработки текста:
            /// а) Вывести только те слова сообщения, которые содержат не более n букв.
            /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            /// в) Найти самое длинное слово сообщения.
            /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            /// Продемонстрируйте работу программы на текстовом файле с вашей программой.
            ///

            Console.WriteLine("Программа для работы с текстом");
            Console.WriteLine("Введите макисмальную длинну слова:");
            int lenght;
            Int32.TryParse(Console.ReadLine(), out lenght);
            Console.WriteLine("Введите символ, слова которые содержат его в конце будут игнорированны:");
            char symb;
            char.TryParse(Console.ReadLine(), out symb);
            string str = Reader.Read("D:/Загрузки/Учеба/Geek/Основы C#/Fifth_Homework/Messages/Program.cs");
            Console.WriteLine("Текст их файла");
            Console.WriteLine(str);
            
            Console.WriteLine($"Текст в котором нет слов длиннее {lenght} символов");
            string cutLen = Reader.CutLenght(str, lenght);
            Console.WriteLine(cutLen);

            Console.WriteLine($"Текст в котором нет слов которые заканчиваются на {symb}");
            string cutSym = Reader.CutSymb(str, symb);
            Console.WriteLine(cutSym);
            
            string maxLenght = Reader.MaxLenght(str);
            Console.WriteLine($"Самое длинное слово: {maxLenght}");

            Console.WriteLine($"Строка из самых длинных слов в тексте");
            string strMax = Reader.StrMax(str);
            Console.WriteLine(strMax);
            Console.ReadKey();
        }
    }
}
