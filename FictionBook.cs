using System;
namespace library_system
{
    public class FictionBook : Book
    {
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