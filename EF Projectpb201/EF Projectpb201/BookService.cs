namespace EF_Projectpb201;

public class BookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public List<Book> GetAllBooks()
    {
        return _bookRepository.GetAll();
    }

    public void AddBook(Book book)
    {
        _bookRepository.Add(book);
    }

    public void UpdateBook(Book book)
    {
        _bookRepository.Update(book);
    }

    public void DeleteBook(int bookId)
    {
        var book = _bookRepository.GetById(bookId);
        if (book != null)
            _bookRepository.Delete(book);
    }
}
