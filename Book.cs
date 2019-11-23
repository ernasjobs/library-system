using System;
using System.Threading;
using System.Collections.Generic;
namespace library_system
{
    public class Book
    {
        private readonly BookClass bookClass;
        public string ID {get;set;}
        public string Title {get;set;}
        public  List<Author> Author {get;set;}
        public string Publisher {get;set;}
        public string DateOfPublication {get;set;}
        public Book(BookClass bookClass,string title,List<Author> author,string publisher,string dataOfPublication)
        {
            this.bookClass=bookClass;
            Title=title;
            Author=author;
            Publisher=publisher;
            DateOfPublication=dataOfPublication;
            ID=CorrelationIdGenerator.GetNextId();
            
        }
        public virtual void DisplayDetails()
        {   string authorList="";
            foreach(var author in Author)
            {
                authorList+=author.Name +", ";
            }
            Console.WriteLine(ID+", "+authorList +", "+Title+", "+Publisher+", "+DateOfPublication);
        }

    }
    internal static class CorrelationIdGenerator  
{
    private static readonly string _encode32Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUV";

    private static long _lastId = DateTime.UtcNow.Ticks;

    public static string GetNextId() => GenerateId(Interlocked.Increment(ref _lastId));

    private static unsafe string GenerateId(long id)
    {
        char* charBuffer = stackalloc char[13];

        charBuffer[0] = _encode32Chars[(int)(id >> 60) & 31];
        charBuffer[1] = _encode32Chars[(int)(id >> 55) & 31];
        charBuffer[2] = _encode32Chars[(int)(id >> 50) & 31];
        charBuffer[3] = _encode32Chars[(int)(id >> 45) & 31];
        charBuffer[4] = _encode32Chars[(int)(id >> 40) & 31];
        charBuffer[5] = _encode32Chars[(int)(id >> 35) & 31];
        charBuffer[6] = _encode32Chars[(int)(id >> 30) & 31];
        charBuffer[7] = _encode32Chars[(int)(id >> 25) & 31];
        charBuffer[8] = _encode32Chars[(int)(id >> 20) & 31];
        charBuffer[9] = _encode32Chars[(int)(id >> 15) & 31];
        charBuffer[10] = _encode32Chars[(int)(id >> 10) & 31];
        charBuffer[11] = _encode32Chars[(int)(id >> 5) & 31];
        charBuffer[12] = _encode32Chars[(int)id & 31];

        return new string(charBuffer, 0, 13);
    }
}
}