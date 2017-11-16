using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    class Program
    {
        static void Main(string[] args)
        {




            /* example 1 
             string password;
           Console.Write("Please enter password:  ");
           password = Console.ReadLine();

           if (password == "abc123")

           { Console.WriteLine("Correct"); }

           else
           { Console.WriteLine("Wrong Password"); }
   */

            //Problem 2 

            /* string pass1, pass2;
             Console.WriteLine("Please enter password:");

             pass1 = Console.ReadLine();

             Console.WriteLine("Please re-enter password:");

             pass2 = Console.ReadLine();

             if (pass1 == pass2)

             { Console.WriteLine("Login Corrrect"); }

             else
             { Console.WriteLine("Login Failed"); }*/



            /*string password1;

            Console.WriteLine("Please enter a password that is 8 characters or longer");

            password1 = Console.ReadLine();

            if (password1.Length < 8)

            { Console.WriteLine("Password is too short"); }

            else
            { Console.WriteLine("Correct length"); }
            */


            

            /*string choice;

            Console.WriteLine("Please choose the letter that corresponds to the type of phone you want:  ");

            Console.WriteLine("(A) iPhone");

            Console.WriteLine("(B) Android");

            choice = Console.ReadLine();

            if (choice == "A"  ||  choice == "a")

            { Console.WriteLine("You chose an iPhone!"); }

            else if (choice == "B" || choice == "b")

            { Console.WriteLine("You chose an Android"); }

            else   //give them another chance - essentially looping 
            {
                Console.Clear();

                Console.WriteLine("Invalid answer, try again");

                Console.WriteLine("Please choose the letter that corresponds to the type of phone you want:  ");

                Console.WriteLine("(A) iPhone");

                Console.WriteLine("(B) Android");
                
            
                choice = Console.ReadLine();

                if (choice == "A" || choice == "a")

                { Console.WriteLine("You chose an iPhone!"); }

                else if (choice == "B" || choice == "b")

                { Console.WriteLine("You chose an Android"); }

                else
                { Console.WriteLine("Get with the program"); } //twice?  come on...

            }
            */

            //sweaters or sweatshirts
            string choice;

            Console.WriteLine("Please choose the letter that corresponds to the type of clothing you want:  ");

            Console.WriteLine("(A) sweatshirt");

            Console.WriteLine("(B) Tshirt");

            choice = Console.ReadLine();

          switch (choice)
            { case "A":

                    Console.WriteLine("You chose a sweatshirt");

                    Console.WriteLine("The cost is 10.00");

                    break;


                case "B":

                    Console.WriteLine("You chose a T-shirt");

                    Console.WriteLine("The cost is 5.00");

                    break;


                default:

                    Console.WriteLine("You chose an invalid answer.");


                    break;
            }

                     
                
                




            Console.ReadKey();

        }


    }
}
