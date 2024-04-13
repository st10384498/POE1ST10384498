using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recipies
{
    class Recipie
    {
        /* methods for creating recipies viewing the recipe and scaling and clearing 
        getters and setters */

        public string NameRecipe { get; set; }
        public string NameIngredients { get; set; }
        public string QuantityIngredients { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string NumberOfSteps { get; set; }
        public string DescriptionIngredients { get; set; }


        public  void RecipeInfo()
        {
            // create obj of the class to assign(set) \
            //have an array that will have a loop To allow users to add more than one recipe


            // this code was adapted (readline read an integer) from stack overflow
            //https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input

            Console.WriteLine("How many recipes would you like to create ");
            int numrecipies = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numrecipies; i++)
            {
                Recipie r = new Recipie();
                Console.WriteLine("Enter the name of your recipe ");
                r.NameRecipe = Console.ReadLine();
                Console.WriteLine("Enter the name of your recipe ");
                r.NameRecipe = Console.ReadLine();

                Console.WriteLine("How many ingredients will this recipe require \n");
                int NumIngredients =Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < NumIngredients; i++)
                {
                    Console.WriteLine("Enter the Ingredients of your recipe \n");
                    r.NameIngredients = Console.ReadLine();

                    Console.WriteLine("Enter the quantity ingredients (e.g. 5 cloves of garlic \n");
                    r.QuantityIngredients = Console.ReadLine();

                    Console.WriteLine("What is the unit Of Measurement (e.g.2 cups of flower)\n");
                    r.UnitOfMeasurement = Console.ReadLine();
                }break;
                Console.WriteLine("How many steps are ivloved in this recipe\n");
                r.NumberOfSteps = Console.ReadLine();

                Console.WriteLine("Give a brief discription of how to make this delicious recipethis recipe\n");
                r.DescriptionIngredients = Console.ReadLine();

            }

        }
    }
}

