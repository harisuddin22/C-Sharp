using System;

namespace DailyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] languages = { "C#", "JavaScript", "React", "Java", "HTML" };

            Console.WriteLine("💡 Programming Languages I Love:");

            // Simple for loop
            for (int i = 0; i < languages.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {languages[i]}");
            }

        }
    }
}
