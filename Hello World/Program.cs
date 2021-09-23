using System;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static int age;
        static string message = "My age is ";
        static double Height;
        static string heightMessage = " and my height in meters is ";


        static void Main(string[] args)
        {


            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            List<string> wordList = new List<string>() { "joe", "mama"};
            for (int i = 0; i < wordList.Count; i++)
            {
                Console.WriteLine(wordList[i]);
            }



            age = 16;
            Height = 1.7;
            Console.WriteLine(message + age + heightMessage + Height);
            Console.ReadKey();
        }
    }


}
