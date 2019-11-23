using System;
using System.Collections.Generic;
namespace library_system
{
    public class NonFictionBook : Book
    {
        protected List<string> Categories=new List<string>(){"Programming","E-Commerce","Web Design"};

        public NonFictionBook(BookClass bookClass, string title, string author, string publisher, string dataOfPublication) : base(bookClass, title, author, publisher, dataOfPublication)
        {
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"{Title} is a nonfiction book");
            base.DisplayDetails();
        }
    }
}