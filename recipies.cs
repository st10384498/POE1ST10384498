using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recipies
{
    class Recipe
    {
        /* methods for creating recipies viewing the recipe and scaling and clearing 
        getters and setters */

        public string NameRecipe { get; set; }
        //Store the ingredients and steps in arrays. 
        public string[] NameIngredients { get; set; }
        public string[] QuantityIngredients { get; set; }
        public string[] UnitOfMeasurement { get; set; }
        public int NumberOfSteps { get; set; }
        public string DescriptionIngredients { get; set; }

        //Constructor for Recipie class to save ingredients to an array the size of num ingredients
        public Recipe(int NumIngredients)
        {
            NameIngredients = new string[NumIngredients];
            QuantityIngredients = new string[NumIngredients];
            UnitOfMeasurement = new string[NumIngredients];
           
        }

        public static Recipe[] RecipeInfo()
        {
            // create obj of the class to assign(set) \
            //have an array that will have a loop To allow users to add more than one recipe
            // this code was adapted (readline read an integer) from stack overflow
            //https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input

            Console.WriteLine("How many recipes would you like to create \n");
            int numrecipes = Convert.ToInt32(Console.ReadLine());
            //array that takes from the consolen the array size
            Recipe[] recipes = new Recipe[numrecipes];

            //loop the according to number of recipies
            for (int i = 0; i < numrecipes; i++)
            {

                Console.WriteLine($"Please enter the name of your {i + 1} recipe :");
                string recipeName = Console.ReadLine();

                Console.WriteLine("How many ingredients will " + recipeName + " require? ");
                int NumIngredients = Convert.ToInt32(Console.ReadLine());
                //class obj to 
                Recipe recipe = new Recipe(NumIngredients);
                //set NameRecp
                recipe.NameRecipe = recipeName;

                //loop according to numbers of ingredients
                for (int j = 0; j < NumIngredients; j++)
                {
                    Console.WriteLine($"Enter the Ingredients for recipe {j + 1} ");
                    recipe.NameIngredients[j] = Console.ReadLine();

                    Console.WriteLine("Enter the quantity ingredients (e.g. 5 cloves of garlic \n");
                    recipe.QuantityIngredients[j] = Console.ReadLine();

                    Console.WriteLine("What is the unit Of Measurement (e.g.1 kg of rice)\n");
                    recipe.UnitOfMeasurement[j] = Console.ReadLine();
                }

                Console.WriteLine("How many steps are ivloved in this recipe\n");
                recipe.NumberOfSteps = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Give a brief discription on how to make this delicious recipethis recipe\n");
                recipe.DescriptionIngredients = Console.ReadLine();


                recipes[i] = recipe;

            }
            return recipes;
        }
    }
}
        //private background method to catch if a user inputs word(chars) instead of ints
    //    private static int CatchUserInput ()
    //    {
    //        //try catch 
    //        while (true)
    //        {
    //            try
    //            {
    //                return Convert.ToInt32(Console.ReadLine());
    //            }
    //            catch (FormatException)
    //            {
    //                Console.WriteLine("Please enter a number .");
    //            }
    //        }
    //    }
    //}

