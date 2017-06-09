using System;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[13] { "Jeff", "Angela", "Chris R.", "Ethan", "Mike", "Justin", "Jessica", "Amanda", "Chris L.", "Brian", "Chris M.", "Juan", "Richard" };
            while (true)
            {
                Random selector = new Random();
                int randomNum = selector.Next(0, 13);
                string result = names[randomNum];
                Console.WriteLine(result);
                Console.WriteLine("Press \"ENTER\" to continue, or type \"quit\" to exit: ");
                string entry = Console.ReadLine().ToLower();
                Console.Clear();


                if (entry == "quit")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}