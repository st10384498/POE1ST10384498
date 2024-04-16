using Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
     class RecipeManager_
    {
            public static void DeleteRecipe(Recipe[] recipes, int index)
        {

            //confirm delete method was adapted from code project
            //https://www.codeproject.com/Questions/586555/displayplusconfirmplusmessageplusboxplusonplusdele
            //accessed 16/04/2024

            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (recipes == null || index < 0 || index >= recipes.Length)
                {
                    Console.WriteLine("Please enter a valid index for the recipe you want to be deleted.\nHint : Recipe 1 = index 0 , Recipe 2 = index1");
                    return;
                }
            //cofirm user choice
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
            Console.ResetColor();
        }

        public static int SearchRecipeIndex(Recipe[] recipes, string recipeName)
        {
            //this code was adapted from
            //https://stackoverflow.com/questions/71863309/search-for-an-element-inside-an-array-in-c-sharp
            //acessed on 16/04/2024
            if (recipes == null || recipeName == null)
            {
                return -1;
            }

            for (int i = 0; i < recipes.Length; i++)
            {
                if (recipes[i].NameRecipe.Equals(recipeName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            // Recipe not found
            return -1; // Recipe not found
        }
    }
}

    
   

