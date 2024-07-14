namespace EF_Projectpb201;

public class LoanItem
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public virtual Book Book { get; set; }
    public int LoanId { get; set; }
    public virtual Loan Loan { get; set; }
}                                                       
