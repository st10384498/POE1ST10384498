using Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipes;

namespace POE1ST10384498
{
     class Delete
    {

        public static void DeleteRecipe(int index)
        {
            if (AllRecipes == null || index < 0 || index >= AllRecipes.Length)
            {
                Console.WriteLine("Invalid recipe index.");
                return;
            }

            Console.WriteLine($"Are you sure you want to delete the recipe '{AllRecipes[index].NameRecipe}'? (yes/no)");
            string confirmation = Console.ReadLine().ToLower();

            if (confirmation == "yes" || confirmation == "y")
            {
                Recipe[] newArray = new Recipe[AllRecipes.Length - 1];
                for (int i = 0, j = 0; i < AllRecipes.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[j++] = AllRecipes[i];
                    }
                }
                AllRecipes = newArray;

                Console.WriteLine("Recipe deleted successfully.");
            }
            else
            {
                Console.WriteLine("Delete operation cancelled.");
            }
        }


    }
}
