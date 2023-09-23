using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alphabet = new List<string>();
           
            for (int i = 65; i <= 90; i++)
            {
                alphabet.Add(((char)i).ToString());
            }
            for (int i = 48; i <= 57; i++)
            {
                alphabet.Add(((char)i).ToString());
            }
            for (int i = 97; i <=122; i++)
            {
               
                alphabet.Add(((char)i).ToString());
            }
            string password = string.Empty;
            Random rnd = new Random();
    
                password = string.Empty;
                for (int i = 0; i < 6; i++)
                {
                    password += alphabet[rnd.Next(0, alphabet.Count)];
                
            }
            Console.WriteLine(password);
           
        }
    }
}
