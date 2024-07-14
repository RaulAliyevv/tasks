namespace EF_Projectpb201
{
    internal class AuthorRepository : IAuthorRepository
    {
        private LibraryContext context;

        public AuthorRepository(LibraryContext context)
        {
            this.context = context;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}