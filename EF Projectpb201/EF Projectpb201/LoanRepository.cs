using EF_Projectpb201;

internal class LoanRepository : ILoanRepository
{
    public LoanRepository(LibraryContext context)
    {
        Context = context;
    }

    public LibraryContext Context { get; }
}