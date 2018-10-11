using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passowrd_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - цифры 2 - буквы 3- цифры буквы + заглавные буквы");
            int a = Int32.Parse(Console.ReadLine());
            string pass = "";
            Random rand = new Random();
            string chars = "qwertyuiopasdfghjklzxcvbnm";
            string chars_dig_vol = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            switch (a)
            {
                case 1:        
                    int s = size_pass();
                    for (int i = 0; i <s; i++)
                    {
                        int r_digit = rand.Next(0,9);
                        pass += r_digit;
                    }
                    break;
                case 2:                 
                  s = size_pass();
                    for (int i = 0; i < s; i++)
                    {
                        
                        pass += Random_char(chars, rand);
                    }
                    break;
                case 3:
                    s = size_pass();
                    Random help_r = new Random();
                    for (int i = 0; i < s; i++)
                    {
                        
                        int help = help_r.Next(0,3);
                        if(help == 0)
                        {
                             
                            pass += Random_char(chars, rand); ;
                        }
                        if (help == 1)
                        {                       
                            pass += rand.Next(0, 9);
                        }
                        if (help == 2)
                        {
                            pass += Random_char(chars_dig_vol, rand);
                        }                
                    }
                    break;            
                default: Console.WriteLine("1-4");
                    break;

            }

            Console.WriteLine("Password = "+pass);
            Console.Read();
        }

        static int size_pass()
        {
            Console.WriteLine("Введите размер пароля");
            int size = Int32.Parse(Console.ReadLine());
            return size;
        }

        static char Random_char(string text,Random rnd)
        {
            int index = rnd.Next(text.Length);
            return text[index];
        }
    }
}
