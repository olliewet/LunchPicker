using System;
using System.Collections.Generic;
using System.Text;

namespace LunchPicker
{
    class Foodoption
    {     
        public static void RandomMethod(string[] arr)
        {
            Random rand = new Random();
            int r = rand.Next(3);
            string str = arr[r];
            Console.WriteLine("The item you should by today is {0}", str);
        }
        public static void WelcomeText()
        {
            //User Instructions 
            Console.WriteLine("Hi Welcome To the Lunch Picker!");
            Console.WriteLine("There are 4 key details i need before deciding where you should eat for lunch!");
            Console.WriteLine("You will be provided with 3 options asking you how much money you would like to spend on your lunch please pick 1!");
            Console.WriteLine("Press 1 - £1 - £5\nPress 2 - £5 - £10\nPress 3 - £10 - £15\n");
        }
    }
}
