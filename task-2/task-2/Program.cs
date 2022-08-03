using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a')
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine("letter 'a' found");
            else
                Console.WriteLine("not found");
        }
    }
}