using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_Your_Class
{
    class Program : Books
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to your bookshelf!");

            bool keepReading = true;

            while (keepReading)
            {
                Console.WriteLine("What would you like to do today?");

                Console.WriteLine("1. Add new books to read.");
                Console.WriteLine("2. Add a book to future reading.");
                Console.WriteLine("3. Add a book to favorites.");
                Console.WriteLine("4. Move a book to finished pile.");
                Console.WriteLine("5. to exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Add book here
                        AddBook();
                        Console.WriteLine();
                        break;
                    case "2":
                        //Add to future reads
                        break;
                    case "3":
                        //Add to favs
                        break;
                    case "4":
                        //Move book to finished stack
                        break;
                    case "5":
                        keepReading = false;
                        break;


                    default:


                        break;
                }
               
            }


            
        }


        public static void AddBook()
        {
            Console.WriteLine("Please enter the name of your book");
            
            string book = Console.ReadLine();
        }
       
    }
}
/*static void Main(string[] args)
           Console.WriteLine("Welcome to your library!");
         {
         }*/