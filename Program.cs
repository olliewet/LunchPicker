using System;

namespace LunchPicker
{
    class Program
    {
        static void Main(string[] args)
        {          
            Foodoption.WelcomeText();
            //Try Catch incase of wrong Input
            try
            {
                //Storing Users Input 
                string userinput = Console.ReadLine();
                int input = int.Parse(userinput);

                //Placing users input through switch statement to decide what method to call
                switch (input)
                {
                    case 1:
                        Option1.Option();
                        break;
                    case 2:
                        Option2.Option();
                        break;
                    case 3:
                        Option3.Option();
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
    }
}
   