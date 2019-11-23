using System;
using System.Collections.Generic;
namespace library_system
{
    public class FictionBook : Book
    {
        protected List<string> Genres=new List<string>(){"Romance","Fantasy","Mystery"};
        public FictionBook(BookClass bookClass, string title, string author, string publisher, string dataOfPublication) : base(bookClass, title, author, publisher, dataOfPublication)
        {
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"{Title} is a fiction book");
            base.DisplayDetails();
        }
    }
}