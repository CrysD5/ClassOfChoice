using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Bookshelf
    {
        public List<string> Shelf = new List<string>();

        /*
         public void InteractWithAll()
        {
            Console.Clear();
            bool keepThinking = true;
            while (keepThinking == true)
            {
                Console.WriteLine("Choose an action!");
                Console.WriteLine("1. Feed all pets.");
                Console.WriteLine("2. Play with all pets.");
                Console.WriteLine("3. Heal all pets.");
                Console.WriteLine("Press Q to return to main menu.");
                string UserInput = Console.ReadLine().ToLower();

                int index = 1;

                switch (UserInput)
                {
                    case "1":
                        foreach (Pet pet1 in ListOfPets)
                        {
                            Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                            pet1.Feed();
                            index++;
                        }
                        break;
                    case "2":
                        foreach (Pet pet1 in ListOfPets)
                        {
                            Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                            pet1.Play();
                            index++;
                        }
                        break;
                    case "3":
                        foreach (Pet pet1 in ListOfPets)
                        {
                            Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                            pet1.SeeDoctor();
                            index++;
                        }
                        break;
                    case "q":
                        keepThinking = false;
                        break;
                    default:
                        break;
                }

            }
            Console.Read();
           
         */


    }
}



        /*public void AddBook(Bookshelf book)
        {
            Bookshelf.Add(book);
        }*/

