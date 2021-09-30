using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{
    public class Books
    {
        public string BookName { set; get; }

        public string Author { set; get; }

        public bool CurrentlyReading { set; get; }

        public bool AlreadyRead { set; get; }

        public int FavoriteBook { set; get; }



         
        public void SetBookName(string book) { this.BookName = book; }
        //public string GetBookName() { return this.BookName; }

        public void SetAuthor(string author) { this.Author = author; }
        public string GetAuthor() { return this.Author; }

        public void SetCurrentlyReading(bool reading) { this.CurrentlyReading = reading; }
        public bool GetCurrentlyReading() { return this.CurrentlyReading; }

        public void SetFavoriteBook(int score) { this.FavoriteBook = score; }
        public int GetFavoriteBook() { return this.FavoriteBook; }




























    }

}
