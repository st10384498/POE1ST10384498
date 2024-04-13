using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Recipies;
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

            Console.WriteLine("\n1. Add recipe\n2. Reset quantities \n3. Display recipie/s \n4. Clear recipie data");
            int option = Convert.ToInt32(Console.ReadLine());
            //have a menue using switch case
            //this code was adapted from codeAcademy
            //https://www.codecademy.com/resources/docs/c-sharp/switch
            //Published Mar 15, 2023•Updated Oct 12, 2023 Accessed on 9/12/2024

            Recipie recipie = new Recipie();
            switch (option)
            {
                case 1:
                    //        // code block
                    recipie.RecipeInfo();
                    break;
                    //    case y:
                    //        // code block
                    //        break;
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
