using EF_Projectpb201;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        LibraryContext _context = null;

        IBookRepository bookRepository = new BookRepository(_context);
        IAuthorRepository authorRepository = GetAuthorRepository(_context);
        IBorrowerRepository borrowerRepository = new BorrowerRepository(_context);
        ILoanRepository loanRepository = new LoanRepository(_context);
        ILoanItemRepository loanItemRepository = new LoanItemRepository(_context);

        BookService bookService = new BookService(bookRepository);
        AuthorService authorService = new AuthorService(authorRepository);
        BorrowerService borrowerService = new BorrowerService(borrowerRepository);
        LoanService loanService = new LoanService(loanRepository, loanItemRepository, bookRepository, borrowerRepository);

        var serviceProvider = new ServiceCollection()
        .AddSingleton<IBookRepository, BookRepository>()
        .AddSingleton<IAuthorRepository, AuthorRepository>()
        .AddSingleton<IBorrowerRepository, BorrowerRepository>()
        .AddSingleton<ILoanRepository, LoanRepository>()
        .AddSingleton<ILoanItemRepository, LoanItemRepository>()
        .AddSingleton<BookService>()
        .AddSingleton<AuthorService>()
        .AddSingleton<BorrowerService>()
        .AddSingleton<LoanService>()
        .BuildServiceProvider();
        _ = serviceProvider.GetRequiredService<BookService>();
        _ = serviceProvider.GetRequiredService<AuthorService>();
        _ = serviceProvider.GetRequiredService<BorrowerService>();
        _ = serviceProvider.GetRequiredService<LoanService>();

        static AuthorRepository GetAuthorRepository(LibraryContext _context)
        {
            AuthorRepository authorRepository1 = new AuthorRepository(_context);
            return authorRepository1;
        }
    }
}
