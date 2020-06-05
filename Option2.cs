using System;
using System.Collections.Generic;
using System.Text;

namespace LunchPicker
{
    class Option2
    {
        public static void Option()
        {
            string randomfood;
            Random rand = new Random();

            string[] food = { "Subway", "Mcdonalds", "Burger King" };
            String result = food[rand.Next(food.Length)];
            randomfood = result;

            if (randomfood == "Subway")
            {
                Console.WriteLine("You have been selected Subway!\nyou will now be provided with the avaliable Options!");

            }
            else if (randomfood == "Mcdonalds")
            {
                Console.WriteLine("You have been selected Mcdonalds!\nyou will now be provided with the avaliable Options!");
                Mcdonalds();
            }
            else if (randomfood == "Burger King")
            {
                Console.WriteLine("You have been selected Burger King!\nyou will now be provided with the avaliable Options!");
            }
        }

        static void Mcdonalds()
        {
            string[] Mcdees = { "Ham", "Bacon", "Tuna" };
            Foodoption.RandomMethod(Mcdees);
        }
    }
}
