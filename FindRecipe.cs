using Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRecipe_
{
     class FindRecipe
    {
        public static void SearchRecipe(Recipe[] recipes, string searchName)
        {
            bool found = false;
            foreach (Recipe recipe in recipes)
            {
                if (recipe.NameRecipe.ToLower() == searchName.ToLower())
                {
                    Console.WriteLine("Recipe found:");
                    Console.WriteLine($"Name: {recipe.NameRecipe}");
                    Console.WriteLine("Ingredients:");
                    for (int i = 0; i < recipe.NameIngredients.Length; i++)
                    {
                        Console.WriteLine($"{recipe.NameIngredients[i]} - {recipe.QuantityIngredients[i]} {recipe.UnitOfMeasurement[i]}");
                    }
                    Console.WriteLine($"Number of Steps: {recipe.NumberOfSteps}");
                    Console.WriteLine($"Description: {recipe.DescriptionIngredients}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Recipe not found.");
            }
        }
    }
}
