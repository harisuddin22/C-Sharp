using System;

namespace DailyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitsNum = "1";

            {
                switch (fruitsNum)
                {
                    case "1":
                        Console.WriteLine("Mango");
                        break;

                    case "2":
                        Console.WriteLine("Banana");
                        break;

                    case "3":
                        Console.WriteLine("Guava");
                        break;

                    case "4":
                        Console.WriteLine("Falsai");
                        break;

                    case "5":
                        Console.WriteLine("Apple");
                        break;

                    default:
                        Console.WriteLine("No Fruit Found");
                        break;
                }
            }
        }
    }
}
