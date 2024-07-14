using EF_Projectpb201;

internal class AuthorService
{
    private IAuthorRepository authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        this.authorRepository = authorRepository;
    }
}