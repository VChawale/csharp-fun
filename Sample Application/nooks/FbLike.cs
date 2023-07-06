using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application.Nooks
{
    internal static class FbLike
    {
        internal static void Like()
        {
            //Facebook like feature

            List<string> likedByPeople = new List<string>();

            Console.WriteLine("My Great Post!");

            while (true)
            {
                Console.Write("Type your name: ");

                var name = Console.ReadLine();


                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                else
                {
                    likedByPeople.Add(name);
                }
                if (likedByPeople.Count == 1)
                {
                    Console.WriteLine(likedByPeople[0] + " likes your post.");
                }
                else if (likedByPeople.Count == 2)
                {
                    Console.WriteLine(likedByPeople[0] + " and " + likedByPeople[1] + " like your post.");
                }
                else
                {
                    Console.WriteLine(likedByPeople[0] + ", " + likedByPeople[1] + " and " + (likedByPeople.Count - 2).ToString() + " other people like your post.");
                }

            }
        }
    }
}
