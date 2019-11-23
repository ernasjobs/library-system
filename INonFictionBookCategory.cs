using System;
using System.Collections.Generic;
namespace library_system
{
    public interface INonFictionBookCategory
    {
         List<string> NonFictionBookCategories {get;set;}
        void SetCategories();
    }
}
