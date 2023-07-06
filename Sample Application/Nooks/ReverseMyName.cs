using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application.Nooks
{
    internal static class ReverseMyName
    {
        internal static void reverseMyName()
        {
            string userName = Console.ReadLine();

            if (!string.IsNullOrEmpty(userName))
            {
                char[] userNameArray = userName.ToCharArray();

                Array.Reverse(userNameArray);

                string finalName = "";

                foreach (char c in userNameArray)
                {
                    finalName += c;
                }
                Console.WriteLine(finalName);
            }
        }
    }
}
