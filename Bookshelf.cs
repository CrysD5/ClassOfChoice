using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Choose_Your_Class
{
    public class Bookshelf 
    {
        public List<Book> Shelf = new List<Book>();
        

        public Book SelectBook()
        {
            
            int index = 1;
            
            foreach (Book myBook in Shelf)
{

                Console.WriteLine($"{index}: {myBook.Name}");
                index++;

            }
            Console.WriteLine("Enter number of book");
            int selectedIndex = Convert.ToInt32(Console.ReadLine());
            return Shelf[selectedIndex - 1];
        }

        public void ListBooks()
        { 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
           
            int index = 1;

            foreach (Book myBook in Shelf)
            {
                
                Console.WriteLine($"\n{index}: Title: {myBook.Name}, Written by {myBook.Author} \n\n");
                index++;

            }
        }

        public void ListFavs()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            int index = 1;

            foreach (Book myBook in Shelf)
            {
                if(myBook.FavoriteBook == true)
                {
                    Console.WriteLine($"{index}: Title: {myBook.Name}, Written by {myBook.Author}\n");
                    index++;
                }
                
            }
        }


        public void ListFavAuthors()
        {//how to make author print once even if multiple books added
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            int index = 1;
            List<string> printedAuthors = new List<string>();

            foreach (Book myBook in Shelf)
            {
                if (myBook.FavoriteAuthor == true && !printedAuthors.Contains(myBook.Author))
                {                    
                    Console.WriteLine($"{index}: {myBook.Author}\n");
                    printedAuthors.Add(myBook.Author);

                    index++;
                }
               
            }
        }

        public void Reading()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
          
            int index = 1;

            foreach (Book myBook in Shelf)
            {
                if  (myBook.CurrentlyReading == true)
                {
                    Console.WriteLine($"{index}: Title: {myBook.Name}, Written by {myBook.Author}\n");
                        index++;                  
                    
                }                
            }
            Console.Write("\n");
        }
       
        public void AddBook()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Please enter the name of your book");
            string name = Console.ReadLine();            
            Console.Write("\n");

            Console.WriteLine("Please enter the author of your book");
            string author = Console.ReadLine();
            Console.Write("\n");
            
            Console.WriteLine("Currently reading?");
            Console.WriteLine("Enter True or False");
            bool reading = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("Favorite Book?");
            Console.WriteLine("Enter True or False");
            bool favorite = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("Favorite Author?");
            Console.WriteLine("Enter True or False");
            bool favoriteAuthor = Convert.ToBoolean(Console.ReadLine());


            Book myBook = new Book();
            myBook.Name = name;
            myBook.Author = author;
            myBook.CurrentlyReading = reading;
            myBook.FavoriteBook = favorite;
            myBook.FavoriteAuthor = favoriteAuthor;
            Shelf.Add(myBook);

            Console.Write("\n\n\n");
            
            
        }

        public void MarkRead()
        {
            Book selectedBook = this.SelectBook();
            Shelf.Remove(selectedBook);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your book has been removed");
            Console.Write("\n\n"); 
        }

        /*
        public void BookInteract()
        {
            Book selectedBook = this.SelectBook();
            Console.WriteLine($"You have chosen {selectedBook}");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add to favorites");
            Console.WriteLine("2. Move to finished pile");
            Console.WriteLine("Enter number of book");

            int choice = 0;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    this.ListFavs();
                    break;
                case 2:
                    this.MarkRead();
                    break;                
                default:
                    break;
            }
        }
        */
    }


}


