using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrustGame
{
    class Program
    {
        class GameTrust
        {
            int amount;
            string[] questions; // массив вопросов и ответов
            List<int> asked = new List<int>(); //массив заданных вопросов
            public GameTrust(int amount)
            {
                string path = "questions.txt";
                if (File.Exists(path))
                {
                    this.amount = amount;                
                    questions = File.ReadAllLines(path);
                }
            }

            public int Start()
            {
                int points = 0;
                Random rnd = new Random();
                for (int i = 0; i < amount; i++) 
                {
                    int num = -1;
                    do
                    {
                        num = rnd.Next(0, questions.Length - 1); //номер вопроса 
                    } while (asked.IndexOf(num) != -1); // проверка на повтор вопроса
                    asked.Add(num);
                    int pos = questions[num].IndexOf('?');
                    string question = questions[num].Substring(0, pos); // вопрос
                    string anwser = questions[num].Substring(pos + 2); // ответ
                    Console.WriteLine(question);
                    string re = Console.ReadLine();
                    if (anwser.ToLower().Equals(re.ToLower()))
                    {
                        points++;
                        Console.WriteLine("Все верно!");
                    }
                    else Console.WriteLine("Вы не правы...");
                }
                return points;
            }
        }
        static void Main(string[] args)
        {
            /// 
            /// Домашняя работа Безукладникова Даниила
            /// 
            ///  **Написать игру «Верю. Не верю». 
            ///  В файле хранятся вопрос и ответ, правда это или нет. 
            ///  Например: «Шариковую ручку изобрели в древнем Египте», «Да». 
            ///  Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку.
            ///  Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. 
            ///  Список вопросов ищите во вложении или воспользуйтесь интернетом.
            ///
            int amount = 5;
            
            Console.WriteLine($"Игра верю не верю. Вам будут заданы {amount} вопросов. Отвечайте только да или нет.");
            GameTrust game = new GameTrust(amount);
            Console.WriteLine($"Поздравляю вы набрали {game.Start()} баллов за ответы.");
            Console.ReadKey();
        }
    }
}
