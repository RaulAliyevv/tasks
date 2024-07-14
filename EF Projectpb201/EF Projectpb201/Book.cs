namespace EF_Projectpb201;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public int PublishedYear { get; set; }
    public virtual ICollection<Author> Authors { get; set; }
    public virtual ICollection<Borrower> Borrowers { get; set; }
    public object Borrower { get; internal set; }
}
