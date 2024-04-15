using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Recipies;
using Prog6221POE1ST10384498_;
using FindRecipe_;
//import all the other classes 
namespace Prog6221POE1ST10384498
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
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
                        Console.WriteLine("2. Search Recipe");
                        Console.WriteLine("3. Exit");

                        Console.WriteLine("Enter your choice:");
                        int choice = Convert.ToInt32(Console.ReadLine());
                //have a menue using switch case
                //this code was adapted from codeAcademy
                //https://www.codecademy.com/resources/docs/c-sharp/switch
                //Published Mar 15, 2023•Updated Oct 12, 2023 Accessed on 9/12/2024
                
                switch (choice)
                        {
                            case 1:
                        // code block
                        //call class objz
                        Recipe[] recipes = Recipe.RecipeInfo();
                                break;
                            case 2:
                        // code block
                        Console.WriteLine("Enter the name of the recipe you want to search:");
                                string searchName = Console.ReadLine();
                        //call class objz
                        recipes = Recipe.RecipeInfo();
                                FindRecipe.SearchRecipe(recipes,searchName);
                                break;
                            case 3:
                        // code block
                        Console.WriteLine("Exiting...");
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a valid option.");
                                break;
                        }
                    }
            

            Console.ReadLine();

                    //Console writeline("\n1 Create recipe, display full recipie , scale recipe ,alter recipe ,clear data end program)
                    //int userOption =ConertTo
                    //int enters =

            
        }
    }
}
