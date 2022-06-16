using System;

namespace CSharp_Cipher
{
    class Program
    {
        public string alphabet { get { return "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; } }

        public Program()
        {
            Say("Welcome! Please type in the console the text to encrypt: ");
            string input = Console.ReadLine();
            int enKey = int.Parse(Console.ReadLine());
           // Say(Encrypt(input.ToUpper(), enKey));
            Say(Decrypt(input.ToUpper(), enKey));


        }

        public string Encrypt(string plaintext, int key)
        {
            string output = string.Empty;
            for(int i = 0; i<plaintext.Length; i++)
            {
                char letter = plaintext[i];
                if (!alphabet.Contains(letter))
                {
                    output +=letter;
                }
                else
                {
                    int currentIndex = alphabet.IndexOf(letter);
                    currentIndex += key;
                    currentIndex %= 26;
                    output += alphabet[currentIndex];
                }
            }
            
            
            return output;
        }

        public string Decrypt(string messyText, int key)
        {
            string output = string.Empty;
            for (int i = 0; i < messyText.Length; i++)
            {
                char letter = messyText[i];
                if (!alphabet.Contains(letter))
                {
                    output += letter;
                }
                else
                {
                    int currentIndex = alphabet.IndexOf(letter);
                    currentIndex -= key;
                    if (currentIndex < 0)
                    {
                        currentIndex += 26;
                        output += alphabet[currentIndex];


                    }
                    else 
                    {
                        currentIndex %= 26;
                        output += alphabet[currentIndex];
                    }

                }
            }


            return output;
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
