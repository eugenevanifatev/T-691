using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int passwordSize = 0;
            int useNumbers = 0;
            int upperRegistry = 0;
            Console.Write("Size: ");
            passwordSize = Convert.ToInt16(Console.ReadLine());
            Console.Write("Use numbers? 1) Yes 2) NO ");
            useNumbers = Convert.ToInt16(Console.ReadLine());

            Console.Write("Use Upper Registry? 1) Yes 2) NO ");
            upperRegistry = Convert.ToInt16(Console.ReadLine());

            string password="";
            for (int i = 0; i < passwordSize; i++)
            {
                double qwe = random.NextDouble();
                if (upperRegistry == 1 && useNumbers == 1)
                    if (qwe > 0.7)
                    password += (char)random.Next((int)'A', (int)'Z');
                    else if (qwe > 0.4)
                        password += (char)random.Next((int)'a', (int)'z');
                    else password += (char)random.Next((int)'0', (int)'9');

                if (upperRegistry == 2 && useNumbers == 1)
                    if (qwe > 0.6)
                        password += (char)random.Next((int)'a', (int)'z');
                else password += (char)random.Next((int)'0', (int)'9');

                if (upperRegistry == 1 && useNumbers == 2)
                    if (qwe > 0.7)
                       password += (char)random.Next((int)'A', (int)'Z');
                    else password += (char)random.Next((int)'a', (int)'z');

                if (upperRegistry == 2 && useNumbers == 2)
                    password += (char)random.Next((int)'a', (int)'z');

            }
            Console.Write("Your password: " + password);
            Console.ReadLine();
        }
    }
}
