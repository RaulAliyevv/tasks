namespace EF_Projectpb201;

public class Loan
{
    public int Id { get; set; }
    public int BorrowerId { get; set; }
    public virtual Borrower Borrower { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime MustReturnDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public virtual ICollection<LoanItem> LoanItems { get; set; }
}