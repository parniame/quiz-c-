namespace ConsoleApp6
{
    public abstract class LibraryItem
    {
        public string Name { get; set; } = "";
        public int ID { get; set; }
        public abstract void Display();
        protected LibraryItem(string name,int id )
        {
            if(id < 0)
            {
                throw new ArgumentException("should be positive int");
            }
            Name = name;
            ID = id;
        }

    }
}
