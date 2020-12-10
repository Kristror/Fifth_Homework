using System;
using System.IO;
using System.Text;

namespace Messages
{
    partial class Program
    {
        class Reader
        {
            public static string Read(string path)
            {
                if (File.Exists(path))
                {
                    StreamReader sr = new StreamReader(path);
                    string[] lines = new string[500];
                    string str = "";
                    while (!sr.EndOfStream)
                    {
                       lines = sr.ReadLine().Split(' ','.');
                       foreach (string word in lines)
                       {
                            str += word.Trim() + " ";
                       }                            
                    }            
                    sr.Close();
                    return str;
                }
                else return "";
            }
            public static string CutLenght(string str, int lenght)
            {
                string[] lines = str.Split(' ');
                str = "";
                foreach (var word in lines)
                    if (word.Length < lenght) str += word+" ";
                return str;
            }

            public static string CutSymb(string str, char symb)
            {
                string[] lines = str.Split(' ');
                str = "";
                foreach (var word in lines)
                    if (!word.EndsWith(symb.ToString())) str += word + " ";
                return str;
            }

            public static string MaxLenght(string str)
            {
                string[] lines = str.Split(' ');
                string maxword = "";
                foreach (var word in lines)
                    if (word.Length > maxword.Length)
                    {
                        maxword = word;
                    }
                return maxword;
            }

            public static string StrMax(string str)
            {
                string max = MaxLenght(str);
                StringBuilder sb = new StringBuilder();

                string[] lines = str.Split(' ');
                foreach (var word in lines)
                    if (word.Length == max.Length)
                    {
                        sb.Append(word+" ");
                    }
                return sb.ToString();
            }
        }
    }
}
