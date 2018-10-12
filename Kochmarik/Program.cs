using System;
using System.Collections.Generic;



namespace passwordGen
{
    class Program
    {
        static string GeneratePassword(int passwordLength, List<int> symbols)
        {
            string password = "";
            Random rand = new Random();

            for(int i = 0; i < passwordLength; ++i)
            {
                int j = rand.Next(0, symbols.Count / 2);
                password += Convert.ToChar(rand.Next(symbols[j*2], symbols[j * 2+1]));
            }

            return password;
        }

        static void Main(string[] args)
        {

            List<int> symbols = new List<int>();

            int passwordLength = 0;

            Console.WriteLine("input password length: ");

            passwordLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("use numbers ?: ");
            Console.WriteLine("1 - yes");
            Console.WriteLine("0 - no");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                symbols.Add(48);
                symbols.Add(57);
            }

            Console.WriteLine("use Leters whith upper case ?: ");
            Console.WriteLine("1 - yes");
            Console.WriteLine("0 - no");


            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                symbols.Add(65);
                symbols.Add(90);
            }

            Console.WriteLine("use Leters whith down case ?: ");
            Console.WriteLine("1 - yes");
            Console.WriteLine("0 - no");


            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                symbols.Add(97);
                symbols.Add(122);
            }

            string password = GeneratePassword(passwordLength, symbols);

            Console.Clear();
            Console.WriteLine(password);


        }
    }
}
