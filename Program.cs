using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Program
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
                Console.WriteLine("Q to exit");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1":
                        //Add book to read
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
                    case "q":
                        keepReading = false;
                        break;


                    default:


                        break;
                }

            }
        }
        /*static void Main(string[] args)
          {
            Console.WriteLine("Welcome to your library!");
          }*/
    }
}
