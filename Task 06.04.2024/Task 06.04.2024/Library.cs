class Library
{
    private List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> FindAllBooksByName(string value)
    {
        return Books.Where(book => book.Name.Contains(value)).ToList();
    }

    public Book FindBookByCode(string code)
    {
        return Books.FirstOrDefault(book => book.Code == code);
    }

    public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
    {
        return Books.Where(book => book.PageCount >= minPageCount && book.PageCount <= maxPageCount).ToList();
    }

    public void RemoveBookByCode(string code)
    {
        Books.RemoveAll(book => book.Code == code);
    }
}