internal class BorrowerService
{
    private IBorrowerRepository borrowerRepository;

    public BorrowerService(IBorrowerRepository borrowerRepository)
    {
        this.borrowerRepository = borrowerRepository;
    }
}