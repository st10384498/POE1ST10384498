
using Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager_
{ 
    class RecipeManager {

        public static void DeleteRecipe(Recipe[] recipes, int index)
        {
            if (recipes == null || index < 0 || index >= recipes.Length)
            {
                Console.WriteLine("Invalid recipe index.");
                return;
            }

            Console.WriteLine($"Are you sure you want to delete the recipe '{recipes[index].NameRecipe}'? (yes/no)");
            string confirmation = Console.ReadLine().ToLower();

            if (confirmation == "yes" || confirmation == "y")
            {
                Recipe[] newArray = new Recipe[recipes.Length - 1];
                for (int i = 0, j = 0; i < recipes.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[j++] = recipes[i];
                    }
                }

                Console.WriteLine("Recipe deleted successfully.");
            }
            else
            {
                Console.WriteLine("Delete operation cancelled.");
            }
        }
    }

}

    //    public void SearchRecipe( string searchName)
    //    {
    //        bool found = false;
    //        foreach (Recipe recipe in recipes)
    //        {
    //            //this code was adapted fro stack over flow
    //            //https://stackoverflow.com/questions/14432114/how-to-return-a-boolean-method-in-java
    //            if (recipe.NameRecipe.ToLower == searchName.ToLower())
    //            {
    //                Console.WriteLine("Recipe found:");
    //                Console.WriteLine($"Name: {recipe.NameRecipe}");
    //                Console.WriteLine("Ingredients:");
    //                for (int i = 0; i < recipe.NameIngredients.Length; i++)
    //                {
    //                    Console.WriteLine($"{recipe.NameIngredients[i]} - {recipe.QuantityIngredients[i]} {recipe.UnitOfMeasurement[i]}");
    //                }
    //                Console.WriteLine($"Number of Steps: {recipe.NumberOfSteps}");
    //                Console.WriteLine($"Description: {recipe.DescriptionIngredients}");
    //                found = true;
    //                break;
    //            }
    //        //error here ?? idk whyy
    //            else 

    //                Console.WriteLine("Recipe not found.");
    //    }   
    //        }

    
