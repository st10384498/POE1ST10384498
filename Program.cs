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
            Console.WriteLine("==============================================================================================================");
            Console.Write("");
            Console.WriteLine("                                   Welcome to MyFoodBook\n               "
                + "This online recipr book allowas you to add and share recipes ");
            Console.Write("");
            Console.WriteLine("===============================================================================================================");
            Console.Write("");

            Console.WriteLine("Select from the menue below to direct your experience!");

            Console.WriteLine("\n1. Add recipe\n2. Reset quantities \n3. Display recipie/s \n4. SearchRecipe \n5. Clear recipie data");
            int option = Convert.ToInt32(Console.ReadLine());


            // make objs for the classes 
            //this code was adapted from stackoverflow :
            //https://stackoverflow.com/questions/35905141/initializing-an-array-public-static-int
            //Recipie recipie = new Recipie();
            Recipe[] recipes = Recipe.RecipeInfo();

            ResetQuantities resetQuantities = new ResetQuantities();

            //have a menue using switch case
            //this code was adapted from codeAcademy
            //https://www.codecademy.com/resources/docs/c-sharp/switch
            //Published Mar 15, 2023•Updated Oct 12, 2023 Accessed on 9/12/2024
            switch (option)
            {
                case 1:
                    // code block
                    Recipe[] recipe = Recipe.RecipeInfo();

                    break;
                case 2:
                    // code block
                    resetQuantities.ChanageQuantities();
                      break;
                case 3:
                    Console.WriteLine("Enter the name of the recipe you want to search:");
                    string searchName = Console.ReadLine();
                    FindRecipe.SearchRecipe(recipes, searchName);
                    break;
                    //    default:
                    //        // code block
                    //        break;
                    //}
                    //make recpipie obj for the class

                    Console.ReadLine();

                    //Console writeline("\n1 Create recipe, display full recipie , scale recipe ,alter recipe ,clear data end program)
                    //int userOption =ConertTo
                    //int enters =

            }
        }
    }
}
