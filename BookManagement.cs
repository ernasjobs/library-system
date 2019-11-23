using System;
using System.Collections.Generic;
namespace library_system
{
    public class BookManagement:IFictionBookGenre,INonFictionBookCategory
    {
        private List<Book> books=new List<Book>();
        protected List<string>fictionBookGenres=new List<string>();
        protected List<string>nonfictionBookCategories=new List<string>();
        public List<string> FictionBookGenres 
        { 
            get {return fictionBookGenres;}
            set {fictionBookGenres=value;} 
        }
        public List<string> NonFictionBookCategories
         {  get {return nonfictionBookCategories;}
            set {nonfictionBookCategories=value;} 
         }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void DisplayBooks()
        {
            foreach(Book book in books)
            {
                book.DisplayDetails();
            }
        }

        public void SetCategories()
        {
           fictionBookGenres.Add("Romance");
           fictionBookGenres.Add("Fantasy");
           fictionBookGenres.Add("Mystery");
           fictionBookGenres.Add("Nature");
        }

        public void SetGenres()
        {
            nonfictionBookCategories.Add("Programming");
            nonfictionBookCategories.Add("Web Design");
            nonfictionBookCategories.Add("User Interface");
        }
    }
}