using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application.Nooks
{
    internal static class UniqueNumberSorter
    {
        internal static void SortUniqueNumbers()
        {
            List<int> numberList = new List<int>();

            while (true)
            {

                if (numberList.Count < 5)
                {
                    Console.WriteLine("Enter new number!");
                    var inputValue = Console.ReadLine();
                    if (int.TryParse(inputValue, out int number))
                    {
                        //if number found in list
                        if (numberList.IndexOf(number) == -1)
                        {
                            numberList.Add(number);
                            continue;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, Enter Valid Number!");
                        continue;
                    }
                }
                else
                {

                    numberList.Sort();
                    Console.WriteLine("Below is sorted list of numbers!");
                    foreach (var number in numberList)
                    {
                        Console.WriteLine(number);
                    }
                    break;

                }
            }
        }
    }
}
