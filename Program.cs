using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_Your_Class
{
    class Program : Book
    {
        public static Bookshelf Bookshelf = new Bookshelf();
        
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to your bookshelf!");
            //System.Threading.Thread.Sleep(250);
            Console.WriteLine("What would you like to do today?");

            //System.Threading.Thread.Sleep(250);

            bool keepReading = true;

            while (keepReading)
            {
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                //Console.WriteLine("What would you like to do today?");


                Console.WriteLine("1. Add new books to read."); //AddBook
                Console.WriteLine("2. View your book list.");
                Console.WriteLine("3. Veiw your favorite books.");
                Console.WriteLine("4. Veiw your favorite authors.");
                Console.WriteLine("5. Veiw books currently reading.");
                Console.WriteLine("6. Remove finished books.");
                Console.WriteLine("7. to exit");

                string userInput = Console.ReadLine();
                Console.Clear();


                switch (userInput)
                {
                    case "1":
                        //Add book here
                        Bookshelf.AddBook();
                        //Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++ Your Bookshelf +++++++++++++++++++++++++++++++++++");
                        Bookshelf.ListBooks();                        
                        break;
                    case "3":
                        //Console.WriteLine("+++++++++++++++++++++++++++++++++++ Your Bookshelf +++++++++++++++++++++++++++++++++++");
                        Bookshelf.ListFavs();
                        break;
                    case "4":
                        //Console.WriteLine("+++++++++++++++++++++++++++++++++++ Your Bookshelf +++++++++++++++++++++++++++++++++++");
                        Bookshelf.ListFavAuthors();
                        break;
                    case "5":
                        //Console.WriteLine("+++++++++++++++++++++++++++++++++++ Your Bookshelf +++++++++++++++++++++++++++++++++++");
                        Bookshelf.Reading();
                        break;
                    case "6":
                        Bookshelf.MarkRead();                        
                        break;
                    case "7":
                        keepReading = false;
                        break;


                    default:
                        


                        break;
                }
               
            }


            
        }


       
       
    }
}
/*static void Main(string[] args)
           Console.WriteLine("Welcome to your library!");
         {
         }*/