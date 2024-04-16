
using System;
using System.Collections.Generic;
using System.Linq;
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
        public string[] QuantityIngredients { get; set; }
        public string[] UnitOfMeasurement { get; set; }
        public int NumberOfSteps { get; set; }
        public string DescriptionIngredients { get; set; }

        public Recipe(int numIngredients)
        {
            NameIngredients = new string[numIngredients];
            QuantityIngredients = new string[numIngredients];
            UnitOfMeasurement = new string[numIngredients];
        }
        // create obj of the class to assign(set) \
        //have an array that will have a loop To allow users to add more than one recipe
        

        //array method was adapted from Stackoverflow
        //https://stackoverflow.com/questions/7712137/array-containing-methods
        //accessed on 09/04/2024
        public static Recipe[] CreateRecipes()
        {
            Console.WriteLine("How many recipes would you like to create?");
            int numRecipes = Convert.ToInt32(Console.ReadLine());
            // this code was adapted (readline read an integer) from stack overflow
            //https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input
            //accessed on 09/04/2024
            Recipe[] recipes = new Recipe[numRecipes];

            for (int i = 0; i < numRecipes; i++)
            {
                //this code was adapted from tutorialsteacher
                //https://www.tutorialsteacher.com/csharp/csharp-for-loop
                Console.WriteLine($"Please enter the name of your {i + 1} recipe:");
                string recipeName = Console.ReadLine();

                Console.WriteLine($"How many ingredients will {recipeName} require?");
                int numIngredients = Convert.ToInt32(Console.ReadLine());

                Recipe recipe = new Recipe(numIngredients);
                recipe.NameRecipe = recipeName;

                for (int j = 0; j < numIngredients; j++)
                {
                    Console.WriteLine($"Enter the ingredient for recipe {j + 1}:");
                    recipe.NameIngredients[j] = Console.ReadLine();

                    Console.WriteLine($"Enter the quantity of ingredient {recipe.NameIngredients[j]}:");
                    recipe.QuantityIngredients[j] = Console.ReadLine();

                    Console.WriteLine($"Enter the unit of measurement for ingredient {recipe.NameIngredients[j]}:");
                    recipe.UnitOfMeasurement[j] = Console.ReadLine();
                }

                Console.WriteLine($"How many steps are involved in {recipe.NameRecipe}?");
                recipe.NumberOfSteps = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Give a brief description of how to make {recipe.NameRecipe}:");
                recipe.DescriptionIngredients = Console.ReadLine();
                Console.Write("");
                recipes[i] = recipe;
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
            Console.WriteLine($"Recipe Name: {NameRecipe}");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < NameIngredients.Length; i++)
            {
                Console.WriteLine($"{NameIngredients[i]} - {QuantityIngredients[i]} {UnitOfMeasurement[i]}");
            }
            Console.WriteLine($"Number of Steps: {NumberOfSteps}");
            Console.WriteLine($"Description: {DescriptionIngredients}");
            Console.ResetColor();
        }
       
    }
}

//namespace Recipies
//{
//    class Recipe
//    {

//        public string[] NameRecipe { get; set; }

//        public string[] NameIngredients { get; set; }
//        public double [] QuantityIngredients { get; set; }
//        public string[] UnitOfMeasurement { get; set; }
//        public int []NumberOfSteps { get; set; }
//        public string[] DescriptionIngredients { get; set; }
//        //big array
//        public string[] Ingredient { get; set; }

//        //method to initialize for Recipie class to save ingredients to an array the size of num ingredients
//        public void InitializeArray (int NumIngredients)
//        {
//            NameIngredients = new string[NumIngredients];
//            QuantityIngredients = new double [NumIngredients];
//            NameRecipe = new string[NumIngredients];
//            UnitOfMeasurement = new string[NumIngredients];
//            DescriptionIngredients = new string[NumIngredients];
//            NumberOfSteps =new int[NumIngredients];
//           Ingredient = new string[NumIngredients];
//        }

//        public void RecipeInfo()
//        {

//            Console.WriteLine("How many recipes would you like to create \n");
//            int numrecipes = Convert.ToInt32(Console.ReadLine());
//            //array that takes from the consolen the array size
//            String[] recipes = new String[numrecipes];
//            string temp = "";
//            //loop the according to number of recipies

//            for (int i = 0; i < numrecipes; i++)
//            {
//                
//                Console.WriteLine($"Please enter the name of your {i + 1} recipe :");
//                NameRecipe[i] = Console.ReadLine();

//                Console.WriteLine("How many ingredients will this recipe require? ");
//                int numIngredients = Convert.ToInt32(Console.ReadLine());

//                //loop according to numbers of ingredients
//                for (int j = 0; j < numIngredients; j++)
//                {
//                    Console.WriteLine($"Enter the Ingredients for recipe {j + 1} ");
//                    NameIngredients[j] = Console.ReadLine();

//                    Console.WriteLine("Enter the quantity ingredients (e.g. 5 cloves of garlic \n");
//                    QuantityIngredients[j] = Convert.ToDouble(Console.ReadLine());

//                    Console.WriteLine("What is the unit Of Measurement (e.g.1 kg of rice)\n");
//                   UnitOfMeasurement[j] = Console.ReadLine();

//                    temp += $"{QuantityIngredients[j]} {UnitOfMeasurement[j]} of name ingridients {j}";
//                }
//                //store everthing into big array
//                Ingredient[i] = temp;
//                Console.WriteLine("How many steps are ivloved in this recipe\n");
//                NumberOfSteps[i]= Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Give a brief discription on how to make this delicious recipe\n");
//                DescriptionIngredients[i] = Console.ReadLine();

//                recipes[i] = $"Recipe:{NameRecipe[i]}\n Ingredients:\n{Ingredient[i]} \nNumber of Steps:{NumberOfSteps[i]} \nDiscription :{DescriptionIngredients[i]}";


//                DisplayRecipe();
//            }

//        }

//           
//            public void DisplayRecipe()
//            {
//                for (int i = 0; i < NameRecipe.Length; i++) {

//                Console.WriteLine($"Recipies: {i+1}\n" +
//                    $"Recipe name: {NameRecipe[i]}\n"+
//                    $"Ingredients: {NameIngredients[i]}\n" +
//                    $"Quantity: {QuantityIngredients[i]}\n"+
//                    $"Unit Of Measurement: {UnitOfMeasurement[i]}"+
//                    $"Number Of Steps: {NumberOfSteps[i]}"+
//                    $"Recipe Description: {DescriptionIngredients[i]}"
//                    );
//            }

//            }
//        }


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

