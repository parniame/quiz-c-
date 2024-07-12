namespace ConsoleApp6
{
    public class Book : LibraryItem
    {
        public string Author { get; set; } = "";
        public Book(string name , int id , string author): base(name, id)
        {
            Author = author;
        }
        public override void Display()
        {
            var str = "Book ,Author : " + Author + "  ,Name : " + Name + $" ,with ID : {ID} " ;
            Console.WriteLine(str);
        }

    }
}
