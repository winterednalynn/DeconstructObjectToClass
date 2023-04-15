using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructObjectToClass
{
    public class Program
    {
      //EDNA LYNN LAXA 
      //PROGRAMMING III 
      //APRIL 11, 2023 
      //DECONSTRUCT OBJECT TO CLASS 
       
        static void Main(string[] args)
        {
            Console.WriteLine("Selena G's Favorite Things & A page for her fans ");

            Dumbells();
            Bicycle();
            SGWaterbottle();
            Mug();
            Notebook(); 
        }
        public static void Dumbells()
        {
            Dumbells theDumbells = new Dumbells("Pink", 50, 45);

            Console.WriteLine("Selena G's Dumbell of choice");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(theDumbells.Benefits);
            Console.WriteLine("--------------------");
            Console.WriteLine("Her desire dumbell");
            Console.WriteLine("------------------");
            Console.WriteLine(theDumbells.ToString());
            Console.WriteLine($"SG's dumbell weight is {theDumbells.Weight}, Would you like to know if this is deemed heavy? Type Yes or No ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();

            if (userInput == "Yes")
            {


                if (theDumbells.Weight >= 45)
                {
                    Console.WriteLine($"{theDumbells.Weight} is heavy");
                    Console.WriteLine("Press Enter to continue");

                }
                else
                {
                    Console.WriteLine("Press Enter to continue");

                }

            }

            Console.ReadKey(); 

        }
        public static void Bicycle()
        {
            Bicycle SGBike = new Bicycle();
            Console.WriteLine();
            Console.WriteLine("SG BIKE 411: ");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine($"SG COLOR BIKE: {SGBike.Color} \n SG BIKE TYPE: {SGBike.Type} \n SG BIKE INFORMATION: {SGBike.Information} \n HOW MUCH IS SG BIKE {SGBike.Price}");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");

            Console.ReadKey();

        }

        public static void SGWaterbottle()
        {
            Waterbottle SGWaterbottle = new Waterbottle();
            Console.WriteLine();
            Console.WriteLine("SG CHOSEN WATER BOTTLE");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Guess what color is SG's Water bottle: ");
            string guessColor = Console.ReadLine(); 

            if(guessColor == SGWaterbottle.Color)
            {
                Console.WriteLine($"Yes, her water bottle color is {SGWaterbottle.Color}, Press Enter To Continue");
            }
            else
            {
                Console.WriteLine($"Ahh, darn. No {guessColor} is not the color of her water bottle because that's not her favorite color, Press Enter To Continue");
            }
            Console.ReadKey();

            Console.WriteLine("SG's WATER BOTTLE INFORMATION: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"SG's WATER BOTTLE PRICE: {SGWaterbottle.Price} \n SG's WATER BOTTLE COLOR: {SGWaterbottle.Color} \n SG's WATER BOTTLE BRAND: {SGWaterbottle.Brand} \n " +
                $" SG'S WATER BOTTLE OUNCE HELD: {SGWaterbottle.Ounces} \n SG's WATER BOTTLE PRICE: {SGWaterbottle.Price}");
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
        }
        public static void Mug ()
        {
            Console.WriteLine();
            Console.WriteLine("CREATE MUG FOR SG");

            Mugs Mug = new Mugs("You're beautiful", "Pink", "Ceramic",32);


            Console.WriteLine("Press Enter to continue");
     
            Console.ReadKey();

        }
        public static void Notebook()
        {
            Console.WriteLine();
            Console.WriteLine("Take a peek into SG's Notebook");

            NOtebook SGnotebook = new NOtebook();

            Console.WriteLine(SGnotebook.ToString());

            Console.WriteLine();
        }
    }
}
