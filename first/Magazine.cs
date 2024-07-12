namespace ConsoleApp6
{
    public class Magazine : LibraryItem
    {
        public string Genre { get; set; }
        public Magazine(string name, int id  , string genre ):base(name,id) 
        {
            
            Genre = genre;
        }
        public override void Display()
        {
            var str = "Magazine, Genre : " + Genre + ", Name:" + Name + $" ,with ID : {ID} ";
            Console.WriteLine(str);
        }

    }
}
