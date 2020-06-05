using System;
using System.Collections.Generic;
using System.Text;

namespace LunchPicker
{
    class Option3
    {
        public static void Option()
        {
            string randomfood;
            Random rand = new Random();

            string[] food = { "Dope Dough", "Dominos", "Papas" };
            //string[] sandwhich = { "Ham", "BLT", "Tuna" };
            String result = food[rand.Next(food.Length)];
            randomfood = result;
            //Console.WriteLine(randomfood);
            if (randomfood == "Dough Dough")
            {
                Console.WriteLine("You have been selected Dough Dough!\nyou will now be provided with the avaliable Options!");
            }
            else if (randomfood == "Dominos")
            {
                Console.WriteLine("You have been selected Dominos!\nyou will now be provided with the avaliable Options!");
            }
            else if (randomfood == "Papas")
            {
                Console.WriteLine("You have been selected Papas!\nyou will now be provided with the avaliable Options!");
            }
        }

        static void Option3TypeOfFood(int input)
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
