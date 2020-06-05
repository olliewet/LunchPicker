using System;
using System.Collections.Generic;
using System.Text;

namespace LunchPicker
{
    class Option1
    {
        public static void Option()
        {
            string randomfood;
            Random rand = new Random();

            string[] food = { "Asda", "Tescos", "Spar" };
            //string[] sandwhich = { "Ham", "BLT", "Tuna" };
            String result = food[rand.Next(food.Length)];
            randomfood = result;
            //Console.WriteLine(randomfood);
            if (randomfood == "Asda")
            {
                Console.WriteLine("You have been selected Asda!\nyou will now be provided with the avaliable Options!");
                Console.WriteLine("Press 1 - For Sandwhiches \nPress 2 - For Salads \nPress 3 - Hot Snacks\n");
                string userinput = Console.ReadLine();
                int input = int.Parse(userinput);
                Option1TypeOfFood(input);
            }
            else if (randomfood == "Tescos")
            {
                Console.WriteLine("You have been selected Tescos!\nyou will now be provided with the avaliable Options!");
                Console.WriteLine("Press 1 - For Sandwhiches \nPress 2 - For Salads \nPress 3 - Hot Snacks\n");
                string userinput = Console.ReadLine();
                int input = int.Parse(userinput);
                Option1TypeOfFood(input);
            }
            else if (randomfood == "Spar")
            {
                Console.WriteLine("You have been selected Spar!\nyou will now be provided with the avaliable Options!");
                Console.WriteLine("Press 1 - For Sandwhiches \nPress 2 - For Salads \nPress 3 - Hot Snacks\n");
                string userinput = Console.ReadLine();
                int input = int.Parse(userinput);
                Option1TypeOfFood(input);
            }
        }

        static void Option1TypeOfFood(int input)
        {
            string[] Sandwhiches = { "Ham", "Bacon", "Tuna" };
            string[] Salads = { "Tuna Salad", "Cheese Salad", "Caesar Salad" };
            string[] HotSnacks = { "Cheese and Ham Toastie", "Tuna Toastie", "Chips" };

            switch (input)
            {
                case 1:
                    Foodoption.RandomMethod(Sandwhiches);
                    break;
                case 2:
                    Foodoption.RandomMethod(Salads);
                    break;
                case 3:
                    Foodoption.RandomMethod(HotSnacks);
                    break;
                default:
                    Console.WriteLine("Please Enter a Correct Option");
                    break;
            }
        }
    }
}
