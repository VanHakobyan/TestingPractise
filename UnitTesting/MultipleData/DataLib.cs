using System;
using System.Linq;

namespace MultipleData
{
    public class DataLib
    {
        public bool IsVerifiedUser(string name,string email, string phone)
        {
            if (name.Length < 4)
            {
                throw new Exception("Wrong name");
            }
            if (!email.Contains("@"))
            {
                throw new Exception("Wrong email");
            }
            if (!phone.Select(x=>!char.IsDigit(x)).Any())
            {
                throw new Exception("Wrong phoneNumber");
            }

            return true;
        }
    }
}
