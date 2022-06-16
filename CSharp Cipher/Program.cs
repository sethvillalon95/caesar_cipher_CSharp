using System;

namespace CSharp_Cipher
{
    class Program
    {

        public Program()
        {
            Say("Welcome! Please type in the console the text to encrypt: ");
            string input = Console.ReadLine();

        }

        public static void Say(Object o)
        {
            Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
