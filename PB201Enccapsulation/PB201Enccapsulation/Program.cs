
namespace PB201Enccapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book book1 = new Book (1, "Vuqar Bileceri", 20, "Lyrics");
           Book book2 = new Book(2, "Stephen King", 11.90, "Horror");
           Book book3 = new Book(3, "Sherlock Holmes", 35, "Detective");
           Book book4 = new Book(4, "The Detective Novel", 40.20, "Detective");

            // Console.WriteLine(book1.Genre);

            Library pb201 = new Library();

            pb201.AddBook (book1);
            pb201.AddBook (book2);
            pb201.AddBook (book3);
            pb201.AddBook(book4);

            foreach (var book in pb201.GetFilteredBooks("horror")) 
            {
                Console.WriteLine (book.Name + " " + book.Genre);
            }
            





        }
    }
}
