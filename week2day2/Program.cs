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

            ////Let's loop with strings
            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split(); //makes it a string array.

            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i] + " ");
            //}
            //Console.WriteLine("\n");

            ////do it

            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i] + " ");
            //}

            //string begin = "Once upon a time";
            //string[] storyWords = begin.Split();
            //Array.Reverse(storyWords);

            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //Console.WriteLine(" ");

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
            ////type must match. then month is temp varaible. Make sure it's not a variable you've already used.
            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}
            ////this will print out all the months.

            //string[] bands = { "Queen", "Anthony Santos", "Glass Animals", "Bon Iver", "Bonobo" };
            //Console.Write("My favorite bands are ");
            //foreach (string band in bands)
            //{
            //    Console.Write(band + " and ");
            //}
            ////note what's going on 


            //do it
            string[] foods = { "aloo gobi", "burgers", "tacos", "coffee" };
            
            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }

            int[] lucky = { 3, 64, 13, 7 };

            foreach (int luck in lucky)
            {
                Console.WriteLine("Your lucky number is: " + luck);
            }





        }
    }
}
