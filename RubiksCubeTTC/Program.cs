using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeTTC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            while (true)
            {
                userInput = Console.ReadKey().ToString();
                Console.WriteLine(userInput.ToString());
                //ProcessInput(userInput);
            }
        }
    }
}
