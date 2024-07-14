using EF_Projectpb201;

internal class LoanItemRepository : ILoanItemRepository
{
    private LibraryContext context;

    public LoanItemRepository(LibraryContext context)
    {
        this.context = context;
    }
}