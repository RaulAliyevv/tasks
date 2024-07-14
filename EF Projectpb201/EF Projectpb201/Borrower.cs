namespace EF_Projectpb201;

public class Borrower
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}
