using EF_Projectpb201;

internal class LoanService
{
    private ILoanRepository loanRepository;
    private ILoanItemRepository loanItemRepository;
    private IBookRepository bookRepository;
    private IBorrowerRepository borrowerRepository;

    public LoanService(ILoanRepository loanRepository, ILoanItemRepository loanItemRepository, IBookRepository bookRepository, IBorrowerRepository borrowerRepository)
    {
        this.loanRepository = loanRepository;
        this.loanItemRepository = loanItemRepository;
        this.bookRepository = bookRepository;
        this.borrowerRepository = borrowerRepository;
    }
}