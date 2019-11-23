using System;
using System.Threading;
namespace library_system
{
    public class App
    {
            BookManagement bookManagement=new BookManagement();
            
        public void Run()
        { 
            
            UserInteraction();
        }
        public void UserInteraction()
        {
            bookManagement.SetCategories();
            bookManagement.SetGenres();
            while(true)
            {
               bool done=true;
               while(done)
               {
                Console.Clear();
                Console.WriteLine("Library Management System");
                Console.WriteLine("1-Add a Fiction Book");
                Console.WriteLine("2-Add a NonFiction Book");
                bool validInput=false;
                int input=0;
                    
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
                        Console.WriteLine("Select a genre:");
                        for(int i=0;i<bookManagement.FictionBookGenres.Count;i++)
                        {
                            Console.WriteLine(i+": "+bookManagement.FictionBookGenres[i]);
                        }
                        int selectedCategoryID=0;
                        bool validID=false;
                        do
                        {
                            try
                            {
                                selectedCategoryID=Convert.ToInt32(Console.ReadLine());
                                if(selectedCategoryID>=0 && selectedCategoryID<bookManagement.FictionBookGenres.Count)
                                {
                                    validID=true;
                                }
                                else
                                {
                                    Console.WriteLine("Option not available. Please try again later!");
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex);
                                Console.WriteLine("Please try again");
                            }

                        }while(!validID);
                        string selectedCategory=bookManagement.FictionBookGenres[selectedCategoryID];
                        Console.WriteLine("You have selected {0}",selectedCategory);
                        string title=Input("Title");
                        string author=Input("Author");
                        string publisher=Input("Plublisher");
                        string dateOfPublication=Input("Date of publication");
                        FictionBook fictionBook=new FictionBook(BookClass.Fiction,title,author,publisher,dateOfPublication);
                        bookManagement.AddBook(fictionBook);
                        string another=Input("Add another? y/n");
                        if(another=="n")
                        {
                         done=false;
                        }
                        else if(another=="y")
                        {
                            done=true;
                        }
                        
                        
                    }
                    else if(input==2)
                    {
                        Console.Clear();
                        Console.WriteLine("You have chosen to add a nonfiction book");
                        Console.WriteLine("Select a category:");
                        for(int i=0;i<bookManagement.NonFictionBookCategories.Count;i++)
                        {
                            Console.WriteLine(i+": "+bookManagement.NonFictionBookCategories[i]);
                        }
                        int selectedCategoryID=0;
                        bool validID=false;
                        do
                        {
                            try
                            {
                                selectedCategoryID=Convert.ToInt32(Console.ReadLine());
                                if(selectedCategoryID>=0 && selectedCategoryID<bookManagement.NonFictionBookCategories.Count)
                                {
                                    validID=true;
                                }
                                else
                                {
                                    Console.WriteLine("Option not available. Please try again later!");
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex);
                                Console.WriteLine("Please try again");
                            }

                        }while(!validID);
                        string selectedCategory=bookManagement.NonFictionBookCategories[selectedCategoryID];
                        Console.WriteLine("You have selected {0}",selectedCategory);
                        string title=Input("Title");
                        string author=Input("Author");
                        string publisher=Input("Plublisher");
                        string dateOfPublication=Input("Date of publication");
                        NonFictionBook nonfictionBook=new NonFictionBook(BookClass.Fiction,title,author,publisher,dateOfPublication);
                        bookManagement.AddBook(nonfictionBook);
                        string another=Input("Add another? y/n");
                        if(another=="n")
                        {
                         done=false;
                        }
                        else if(another=="y")
                        {
                            done=true;
                        }
                       
                    }
               }
           
            Console.Clear();
            Console.WriteLine("All books in library:");
            bookManagement.DisplayBooks();
            ConsoleKeyInfo inputKey;
            do
            {
                inputKey = Console.ReadKey();
                
            } while (inputKey.Key == ConsoleKey.Escape);         
         }
    }
          public static string Input(string promt)
        {
            Console.Write(promt+": ");
            return Console.ReadLine();
        }
        public  void DisplayBooks()
        {
           

        }
    }
}