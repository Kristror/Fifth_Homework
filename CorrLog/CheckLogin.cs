using System.Text.RegularExpressions;

namespace CorrLog
{
    partial class Program
    {
        static class CheckLogin
        {
            public static bool RegCheck(string login)
            {
                Regex reg = new Regex("^[A-Za-z][A-Za-z0-9]{2,10}$");

                return reg.IsMatch(login);
            }
            public static bool Check(string login)
            {                
                if (char.IsDigit(login[0])) return false;
                if((login.Length < 2)||(login.Length > 10)) return false;
                for (int i = 0; i < login.Length; i++)
                {
                    if ((!char.IsLetter(login[i])) && (!char.IsDigit(login[i]))) return false;
                }
                return true;
            }
        }
    }
}
