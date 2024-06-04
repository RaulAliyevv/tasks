class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Programming", "John Doe", 300);
        Console.WriteLine(book1.Code); 

        Book book2 = new Book("C# Programming", "Jane Smith", 250);
        Console.WriteLine(book2.Code); 
    }
}
