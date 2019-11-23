using System;
namespace library_system
{
    public class UserInputManagement
    {
        public void Run()
        {
            UserInteraction();
        }
        
        
        public void UserInteraction()
        {
            BookManagement bookManagement=new BookManagement();
            bookManagement.SetCategories();
            bookManagement.SetGenres();
            bool done=false;

            while(true)
            {
                Console.Clear();
                int input=0;
               
                    string another=Input("Add a book y/n");
                    if(another=="n")
                    {
                        done=true;
                    }
                
               
                while(!done)
                {   Console.Clear();
                    Console.WriteLine("1-Fiction book");
                    Console.WriteLine("2-Nonfiction book");
                    bool validInput=false;
                    
                    do
                    {
                        try
                        {
                             input=Convert.ToInt32(Console.ReadLine());
                            if(input==1 || input==2)
                            {
                                validInput=true;
                            }
                            else
                            {
                                Console.WriteLine("Option not available please try again");
                            }
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex);
                            Console.WriteLine("Please try again");
                        }
                    }while(!validInput);
                    if(input==1)
                    {
                        Console.Clear();
                        Console.WriteLine("You have chosen to add a fiction book");
                        string title=Input("Title");
                        string author=Input("Author");
                        string publisher=Input("Plublisher");
                        string dateOfPublication=Input("Date of publication");
                        FictionBook fictionBook=new FictionBook(BookClass.Fiction,title,author,publisher,dateOfPublication);
                        bookManagement.AddBook(fictionBook);
                        Console.Clear();
                        Console.WriteLine("All books in library:");
                        bookManagement.DisplayBooks();
                        another=Input("Add a book y/n");
                        if(another=="n")
                        {
                            done=true;
                        }
                        else if(another=="y")
                        {
                            done=false;
                        }
                        //Thread.Sleep(5000);
                        //done=true;
                    }
                    else if(input==2)
                    {
                        Console.Clear();
                        Console.WriteLine("You have chosen to add nonfiction book");
                        string title=Input("Title");
                        string author=Input("Author");
                        string publisher=Input("Plublisher");
                        string dateOfPublication=Input("Date of publication");
                        NonFictionBook nonfictionBook=new NonFictionBook(BookClass.NonFiction,title,author,publisher,dateOfPublication);
                        bookManagement.AddBook(nonfictionBook);
                      //  Thread.Sleep(5000);
                       // done=true;
                        Console.Clear();
                        Console.WriteLine("All books in library:");
                        bookManagement.DisplayBooks();
                        another=Input("Add a book y/n");
                        if(another=="n")
                        {
                            done=true;
                        }
                            else if(another=="y")
                        {
                            done=false;
                        }
                    }
                    
                }
                Console.Clear();
                 Console.WriteLine("All books in library:");
                        bookManagement.DisplayBooks();
                        another=Input("Add a book y/n");
                        if(another=="n")
                        {
                            done=true;
                        }
                        else if(another=="y")
                        {
                            done=false;
                        }
                   
            }
        }
        public static string Input(string promt)
        {
            Console.Write(promt+": ");
            return Console.ReadLine();
        }
        
    }
}