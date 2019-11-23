using System;
using System.Collections.Generic;
namespace library_system
{
    public interface IFictionBookGenre
    {
        List<string> FictionBookGenres {get;set;}
        void SetGenres();
    }
}