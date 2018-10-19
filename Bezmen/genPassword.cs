using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static string Generator(bool upperCase, bool lowerCase, bool digits)
        {
            Random rand = new Random();
            int lengthPasword = rand.Next(8, 24);
            string symbols = "";
            string upperSymbols = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lowerSymbols = "qwertyuiopasdfghjklzxcvbnm";
            string _digits = "123456789987654123";
            string password = "";
            symbols += upperCase ? upperSymbols: null;
            symbols += lowerCase ? lowerSymbols : null;
            symbols += digits ? _digits : null;
            for (int i = 0; i < lengthPasword; i++)
            {
                password += symbols[rand.Next(0, symbols.Length)];
            }
            return password;
        }
        static void Main(string[] args)
        {
            bool upperCase = false;
            bool lowerCase = false;
            bool digits = false;
            bool flag = false;
            int key;
            string status;
            while (!flag)
            {
                status = !upperCase ? "OFF" : "ON";
                Console.WriteLine("1. Верхинй регистр: " + status);
                status = !lowerCase ? "OFF" : "ON";
                Console.WriteLine("2. Нижний регистр: " + status);
                status = !digits ? "OFF" : "ON";
                Console.WriteLine("3. Цифры: " + status);
                Console.WriteLine("4. Сгенерировать");
                key = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (key)
                {
                    case 1: upperCase = upperCase ? false : true; break;
                    case 2: lowerCase = lowerCase ? false : true; break;
                    case 3: digits = digits ? false : true; break;
                    case 4: Console.WriteLine("Пароль: " + Generator(upperCase, lowerCase, digits)); break;
                    default: Console.WriteLine("Error"); break;
                }
            }
            Console.ReadKey();
        }
    }
}
