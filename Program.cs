﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RecipeManager;
using Recipes;
//using FindRecipe_;

//import all the other classes 
namespace Prog6221POE1ST10384498
{
    class Program
    {
        static void Main(string[] args)
        {
            //this code was adapted colour: https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/
            //author:GeeksforGeeks
            //accessed: 14 April 2024
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===============================================================================================================");
            Console.Write("");
            Console.WriteLine("                                   Welcome to MyFoodBook\n               "
                + "This online recipr book allowas you to add and share recipes ");
            Console.Write("");
            Console.WriteLine("===============================================================================================================");
            Console.Write("");

            Console.WriteLine("Select from the menue below to direct your experience!");
            Console.Write("");
            Console.ResetColor();

            while (true)
            {

                //Console.WriteLine("Enter your choice:");
                //int choice = Convert.ToInt32(Console.ReadLine());
                //have a menue using switch case
                //this code was adapted from codeAcademy
                //https://www.codecademy.com/resources/docs/c-sharp/switch
                //Published Mar 15, 2023•Updated Oct 12, 2023 Accessed on 9/12/2024


                Recipe[] recipes = null;

                while (true)
                {

                    //"Menu:"
                    Console.WriteLine("Choose an action:");
                    Console.WriteLine("1. Create Recipes");
                    Console.WriteLine("2. Display Recipe");
                    Console.WriteLine("3. Delete Recipe");
                    Console.WriteLine("4. Search Recipe");
                    Console.WriteLine("5. Exit");

                    int choice;
                    //this code was adapted from reddit: how to get valid input from console
                    //https://www.reddit.com/r/csharp/comments/oix441/im_trying_to_make_a_while_loop_that_keeps_running/
                    //acessed on 16/2024
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                    {
                        Console.WriteLine("Please select between option number 1 and 4.");
                    }

                    switch (choice)
                    {
                        case 1:
                            // code block
                            recipes = Recipe.CreateRecipes();
                            break;
                        case 2:

                            // code block
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            if (recipes == null)
                            {
                                Console.WriteLine("No recipes available. Please create recipes first.");
                            }
                            else
                            {
                                Console.WriteLine("Enter the index of the recipe you want to display:");
                                int index;
                                while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= recipes.Length)
                                {
                                    Console.WriteLine($"Invalid index. Please enter a number between 0 and {recipes.Length - 1}.");
                                }
                                recipes[index].DisplayRecipe();
                            }
                            Console.ResetColor();
                            break;
                        case 3:
                            // code block
                            if (recipes == null)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("No recipes available. Please create recipes first.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Enter the index of the recipe you want to delete:");
                                int indexToDelete;
                                while (!int.TryParse(Console.ReadLine(), out indexToDelete) || indexToDelete < 0 || indexToDelete >= recipes.Length)
                                {
                                    Console.WriteLine($"Invalid index. Please enter a number between 0 and {recipes.Length - 1}.\nHint : Recipe 1 = index 0 , Recipe 2 = index1");
                                }
                                RecipeManager_.DeleteRecipe(recipes, indexToDelete);
                            }
                            break;
                        case 4:
                            if (recipes == null)
                            {
                                Console.WriteLine("No recipes available. Please create recipes first.");
                            }
                            else
                            {
                                Console.WriteLine("Enter the name of the recipe you want to search:");
                                string recipeName = Console.ReadLine();
                                int recipeIndex = RecipeManager_.SearchRecipeIndex(recipes, recipeName);
                                if (recipeIndex != -1)
                                {
                                    Console.WriteLine($"Recipe '{recipeName}' found at index {recipeIndex}.");
                                }
                                else
                                {
                                    Console.WriteLine($"Recipe '{recipeName}' not found.");
                                }
                            }
                            break;
                        case 5:
                            Console.WriteLine("Exiting...");
                            return;
                    }
                }


                Console.ReadLine();


            }

        }
    }
}
