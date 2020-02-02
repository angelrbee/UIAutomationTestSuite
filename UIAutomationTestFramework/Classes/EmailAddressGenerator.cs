using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomationTestFramework.Classes
{
    public class EmailAddressGenerator
    {
        private static Random random = new Random();
        public static string RandomEmail()
        {
            var email = $"{RandomString(5)}@random.com";
            return email;
        }

        private static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}
