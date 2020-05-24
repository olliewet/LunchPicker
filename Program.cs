using System;

namespace LunchPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables to hand;e User Input 
            string userinput;
            int input;

            //User Instructions 
            Console.WriteLine("Hi Welcome To the Lunch Picker!");
            Console.WriteLine("There are 4 key details i need before deciding where you should eat for lunch!");
            Console.WriteLine("You will be provided with 3 options asking you how much money you would like to spend on your lunch please pick 1!");
            Console.WriteLine("Press 1 - £1 - £5\nPress 2 - £5 - £10\nPress 3 - £10 - £15\n");

            //Try Catch incase of wrong Input
            try
            {
                //Storing Users Input 
                userinput = Console.ReadLine();
                input = int.Parse(userinput);

                //Placing users input through switch statement to decide what method to call
                switch (input)
                {
                    case 1:
                        Option1();
                        break;
                    case 2:
                        Option2();
                        break;
                    case 3:
                        Option3();
                        break;

                    default:
                        Console.WriteLine("Please Enter a Correct Option");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please Enter a Correct Option!");
            }



        }
        static void Option1()
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
                TypeOfFood(input);
            }
            else if (randomfood == "Tescos")
            {
                Console.WriteLine("You have been selected Tescos!\nyou will now be provided with the avaliable Options!");
                Console.WriteLine("Press 1 - For Sandwhiches \nPress 2 - For Salads \nPress 3 - Hot Snacks\n");
                string userinput = Console.ReadLine();
                int input = int.Parse(userinput);
                TypeOfFood(input);
            }
            else if (randomfood == "Spar")
            {
                Console.WriteLine("You have been selected Spar!\nyou will now be provided with the avaliable Options!");
                Console.WriteLine("Press 1 - For Sandwhiches \nPress 2 - For Salads \nPress 3 - Hot Snacks\n");
                string userinput = Console.ReadLine();
                int input = int.Parse(userinput);
                TypeOfFood(input);
            }
        }

        static void Option2()
        {
            string randomfood;
            Random rand = new Random();

            string[] food = { "Subway", "Mcdonalds", "Burger King" };
            //string[] sandwhich = { "Ham", "BLT", "Tuna" };
            String result = food[rand.Next(food.Length)];
            randomfood = result;
            //Console.WriteLine(randomfood);
            if (randomfood == "Subway")
            {
                Console.WriteLine("You have been selected Subway!\nyou will now be provided with the avaliable Options!");
            }
            else if (randomfood == "Mcdonalds")
            {
                Console.WriteLine("You have been selected Mcdonalds!\nyou will now be provided with the avaliable Options!");
            }
            else if (randomfood == "Burger King")
            {
                Console.WriteLine("You have been selected Burger King!\nyou will now be provided with the avaliable Options!");
            }
        }

        static void Option3()
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

        static void RandomMethod ( string[] arr)
        {
            Random rand = new Random();
            int r = rand.Next(3);          
            string str = arr[r];
            Console.WriteLine("The item you should by today is {0}",str);
        }

        static void TypeOfFood (int input)
        {
         
            string[] Sandwhiches = {"Option1", "Option2", "Option3" };
            string[] Salads =  {"Option1", "Option2", "Option3" };
            string[] HotSnacks = { "Option1", "Option2", "Option3" };

       
          
            switch (input)
            {
                case 1:
                    Console.WriteLine("Sandwhiches");
                    RandomMethod(Sandwhiches);
                    break;
                case 2:
                    Console.WriteLine("Salads");
                    RandomMethod(Sandwhiches);
                    break;
                case 3:
                    Console.WriteLine("Hot Snacks");
                    RandomMethod(Sandwhiches);
                    break;

                default:
                    Console.WriteLine("Please Enter a Correct Option");
                    break;
            }
        }
    }

}


      
   