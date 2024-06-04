namespace PB201Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("Programming", "John Doe", 300, 1));
            library.AddBook(new Book("Data Structures", "Alice Smith", 250, 2));
            library.AddBook(new Book("E Programming", "Bob Johnson", 400, 3));

            Book foundBook = library.FindBookByCode("PR02");
            if (foundBook != null)
            {
                Console.WriteLine($"Found Book: {foundBook.Name}");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }
    }
}
