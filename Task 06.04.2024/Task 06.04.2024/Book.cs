class Book
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public string Code { get; private set; }

    private static int bookCount = 0;

    public Book(string name, string authorName, int pageCount)
    {
        Name = name;
        AuthorName = authorName;
        PageCount = pageCount;
        Code = $"{name[0].ToString().ToUpper()}{++bookCount}";
    }
}
