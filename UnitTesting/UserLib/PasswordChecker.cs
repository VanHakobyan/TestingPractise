using System;
using System.Text.RegularExpressions;

namespace UserLib
{
    public class PasswordChecker
    {
        public static int GetPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password)) return 0;

            var result = 0;

            if (Math.Max(password.Length, 7) > 7) result++;
            if (Regex.Match(password,"[a-z]").Success) result++;
            if (Regex.Match(password,"[A-Z]").Success) result++;
            if (Regex.Match(password,"[0-9]").Success) result++;
            if (Regex.Match(password,"[\\!\\@\\#\\$\\%]").Success) result++;
            
            return result;
        }
    }
}
