using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i <= 10; i+=2) // that writes up, skips a number
            //{
            //   Console.WriteLine(i);                
            //}
            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greetings = "My name is Jordan";
            //string[] words = greetings.Split();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //} 
            /////that was with Jordan.

            //Okay, walking through this again.


            //for (int i = 1; i <= 10; i++) //generally just used within this for loop.
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.Write(counter + " "); //can put it on the same line. Make sure you concatenate an empty string
            //}

            //Console.WriteLine("");

            //Let's loop with strings
            string greeting = "My name is Little Bill";
            string[] words = greeting.Split(); //makes it a string array.
            
            for(int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine("\n");

            







        }
    }
}
