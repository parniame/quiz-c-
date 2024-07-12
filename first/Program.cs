namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library1 = new Library<Book>();
            var library2 = new Library<Magazine>();
            var book1 = new Book("death", 0, "shekspier");
            var book2 = new Book("life", 1, "liam");
            var magazine1 = new Magazine("old age", 0, "horror");
            var magazine2 = new Magazine("Youth",1,"Drama");
            library1.ADD(book1);
            library1.ADD(book2);
            Console.WriteLine("libray 1 : \n");
            library1.ShowAllList();
            library1.REMOVE(book2);
            Console.WriteLine("\nlibray 1  after remove: \n");
            library1.ShowAllList();

            library2.ADD(magazine1);
            library2.ADD(magazine2);
            Console.WriteLine("\nlibray 2 : \n");
            library2.ShowAllList();
            Console.WriteLine($"\nlibray 2, search item with name {magazine1.Name}  : \n");
            library2.Search(magazine1.Name);
            Console.WriteLine($"\nlibray 2, search item with ID {magazine2.ID}  : \n");
            library2.Search(magazine2.ID);
        }
    }
}
