using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int amountDigits = rand.Next(8, 24);
            int randomSymbol;
            string password = "";
            string symbols = "zxcvbnmasdfghjklqwertyuiop123456789ZXCVBNMASDFGHJKLQWERTYUIOP";
            for (int i = 0; i < amountDigits; i++)
            {
                randomSymbol = rand.Next(0, symbols.Length);
                password += symbols[randomSymbol];
            }
            Console.WriteLine(password);
            Console.ReadKey();
        }
    }
}
