using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    partial class Program
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
    }
}
