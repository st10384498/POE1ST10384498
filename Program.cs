using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Prog6221POE1ST10384498_;
using RecipeManager_;
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
            //Console.WriteLine("\n1. Add recipe\n2. Reset quantities \n3. SearchRecipe  \n4. Display recipie/s \n5. Clear recipie data");
            //int option = Convert.ToInt32(Console.ReadLine());

            //Class obj for recipe
            // Recipe recipe = new Recipe();
            // make objs for the classes 

            //this code was adapted from stackoverflow :
            // https://stackoverflow.com/questions/35905141/initializing-an-array-public-static-int

            //    case 2:
            //        // code block
            //        ResetQuantities resetQuantities = new ResetQuantities();
            //        resetQuantities.ChanageQuantities();
            //          break;

            while (true)
            {
                //"Menu:"
                Console.WriteLine("1. Create Recipes");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Search Recipe");
                Console.WriteLine("4. Delete Recipe");
                Console.WriteLine("6. Exit");

                //Console.WriteLine("Enter your choice:");
                //int choice = Convert.ToInt32(Console.ReadLine());
                //have a menue using switch case
                //this code was adapted from codeAcademy
                //https://www.codecademy.com/resources/docs/c-sharp/switch
                //Published Mar 15, 2023•Updated Oct 12, 2023 Accessed on 9/12/2024

                //switch (choice)
                //        {
                //            case 1:
                //        // code block
                //        //call class objz
                //        Recipe[] recipes = Recipe.CreateRecipes();
                //        Console.Write("");
                //        recipes[0].DisplayRecipe();
                //        break;
                //            case 2:
                //        //recipe.DisplayRecipe();
                //        //        break;
                //        case 3:
                //        //    //code block
                //        //Console.WriteLine("Enter the name of the recipe you want to search:");
                //        //string searchName = Console.ReadLine();
                //        ////call class obj

                //            RecipeManager.DeleteRecipe(recipes[], 0);
                //        break;
                //    case 6:
                //        // code block
                //        Console.WriteLine("Exiting...");
                //                return;
                //            default:
                //                Console.WriteLine("Invalid choice. Please enter a valid option.");
                //                break;
                //        }
                //    }

                
                        Recipe[] recipes = null;

                        while (true)
                        {
                            Console.WriteLine("Choose an action:");
                            Console.WriteLine("1. Create Recipes");
                            Console.WriteLine("2. Display Recipe");
                            Console.WriteLine("3. Delete Recipe");
                            Console.WriteLine("4. Exit");

                            int choice;
                            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                            {
                                Console.WriteLine("Please enter a number between 1 and 4.");
                            }

                            switch (choice)
                            {
                                case 1:
                                    recipes = Recipe.CreateRecipes();
                                    break;
                                case 2:
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
                                    break;
                                case 3:
                                    if (recipes == null)
                                    {
                                        Console.WriteLine("No recipes available. Please create recipes first.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter the index of the recipe you want to delete:");
                                        int indexToDelete;
                                        while (!int.TryParse(Console.ReadLine(), out indexToDelete) || indexToDelete < 0 || indexToDelete >= recipes.Length)
                                        {
                                            Console.WriteLine($"Invalid index. Please enter a number between 0 and {recipes.Length - 1}.");
                                        }
                                        RecipeManager.DeleteRecipe(recipes, indexToDelete);
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Exiting...");
                                    return;
                            }
                        }
                    }


                    Console.ReadLine();

                    //Console writeline("\n1 Create recipe, display full recipie , scale recipe ,alter recipe ,clear data end program)
                    //int userOption =ConertTo
                    //int enters =
                }

            }
        }
 
