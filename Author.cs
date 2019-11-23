namespace library_system
{
    public class Author
    {
        private string name;
        public string Name
        {
            get{return name;}
            set{name=value;}
        }
        public Author(string name)
        {
            this.name=name;
        }
    }
}