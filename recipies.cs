
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    class Recipe
    {
        /* methods for creating recipies viewing the recipe and scaling and clearing 
   getters and setters */

        public string NameRecipe { get; set; }
        //Store the ingredients and steps in arrays. 
        public string[] NameIngredients { get; set; }
        public double[] QuantityIngredients { get; set; }
        public string[] UnitOfMeasurement { get; set; }
        public int NumberOfSteps { get; set; }
        public string DescriptionIngredients { get; set; }

        //constructor to initialise the array size
        //these will increase based on the number of ingredients
        public Recipe(int numIngredients)
        {
            NameIngredients = new string[numIngredients];
            QuantityIngredients = new double[numIngredients];
            UnitOfMeasurement = new string[numIngredients];
        }
        // create obj of the class to assign(set) \
        //have an array that will have a loop To allow users to add more than one recipe

        //this code was adapted from stackoverflow :
        // https://stackoverflow.com/questions/35905141/initializing-an-array-public-static-int

        public static Recipe[] CreateRecipes()
        //array method was adapted from Stackoverflow
        //https://stackoverflow.com/questions/7712137/array-containing-methods
        //accessed on 09/04/2024
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("How many recipes would you like to create?");
            Console.ResetColor();
            int numRecipes = Convert.ToInt32(Console.ReadLine());
            // this code was adapted (readline read an integer) from stack overflow
            //https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input
            //accessed on 09/04/2024
            Recipe[] recipes = new Recipe[numRecipes];

            for (int i = 0; i < numRecipes; i++)
            {
                //this code was adapted from tutorialsteacher
                //https://www.tutorialsteacher.com/csharp/csharp-for-loop
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please enter the name of your {i + 1} recipe:");
                Console.ResetColor();
                string recipeName = Console.ReadLine();
               

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"How many ingredients will {recipeName} require?");
                Console.ResetColor();
                int numIngredients = Convert.ToInt32(Console.ReadLine());
               

                //recipe class obj
                Recipe recipe = new Recipe(numIngredients);
                //make input = to array(save to array)
                recipe.NameRecipe = recipeName;

                //loop according to numbers of ingredients
                for (int j = 0; j < numIngredients; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Enter the ingredient for recipe {j + 1}:");
                    Console.ResetColor();    
                    recipe.NameIngredients[j] = Console.ReadLine();
                    


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Enter the quantity of ingredient (e.g. 5 |cloves of garlic|) {recipe.NameIngredients[j]}."+"\nHint only enter integer value :");
                    Console.ResetColor();
                    recipe.QuantityIngredients[j] = Convert.ToDouble(Console.ReadLine());
                   


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Enter the unit of measurement for ingredient(e.g.1 kg ) {recipe.NameIngredients[j]}:");
                    Console.ResetColor();
                    recipe.UnitOfMeasurement[j] = Console.ReadLine();
                   
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"How many steps are involved in {recipe.NameRecipe}?");
                Console.ResetColor();
                recipe.NumberOfSteps = Convert.ToInt32(Console.ReadLine());
                

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Give a brief description of how to make {recipe.NameRecipe}:");
                Console.ResetColor();
                recipe.DescriptionIngredients = Console.ReadLine();
                
                Console.Write("");
                recipes[i] = recipe;
                recipes[i].DisplayRecipe();
                Console.Write("");
            }
           
            return recipes;
         
        }
        // Method to display a recipe
        //this code was adapted stack overflow
        /// /https://stackoverflow.com/questions/7949189/displaying-array-within-method
        //how to print items from an array
        //accessed 09/04/24
        public void DisplayRecipe()
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("======================================== Display Recipe ==========================================================");
            Console.Write("");
            Console.WriteLine($"Recipe Name: {NameRecipe}");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < NameIngredients.Length; i++)
            {
                Console.WriteLine($"{NameIngredients[i]} - {QuantityIngredients[i]} {UnitOfMeasurement[i]}");
            }
            Console.WriteLine($"Number of Steps: {NumberOfSteps}");
            Console.WriteLine($"Description: {DescriptionIngredients}");
            Console.Write("");
            Console.WriteLine("===================================================================================================================");
            Console.ResetColor();
            Console.Write("");
        }
        public void ScaleRecipe(double factor)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (factor <= 0)
            {
                Console.WriteLine("Factor must be greater than zero.");
                return;
            }

            for (int i = 0; i < QuantityIngredients.Length; i++)
            {
                QuantityIngredients[i] *= factor;
            }

            Console.WriteLine($"Recipe scaled by a factor of {factor}.");
            Console.ResetColor();
            Console.Write("");
        }
    }
}


//}
//        //private background method to catch if a user inputs word(chars) instead of ints
//    //    private static int CatchUserInput ()
//    //    {
//    //        //try catch 
//    //        while (true)
//    //        {
//    //            try
//    //            {
//    //                return Convert.ToInt32(Console.ReadLine());
//    //            }
//    //            catch (FormatException)
//    //            {
//    //                Console.WriteLine("Please enter a number .");
//    //            }
//    //        }
//    //    }
//    //}

