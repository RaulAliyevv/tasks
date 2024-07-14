using Microsoft.EntityFrameworkCore;

namespace EF_Projectpb201;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Borrower> Borrowers { get; set; }
    public DbSet<Loan> Loans { get; set; }
    public DbSet<LoanItem> LoanItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Book>()
                    .HasMany(b => b.Authors)
                    .WithMany(a => a.Books)
                    .UsingEntity(j => j.ToTable("BookAuthors"));

        modelBuilder.Entity<Borrower>()
                    .HasMany(b => b.Books)
                    .WithOne(book =>
                    {
                        _ = book.Borrower;
                        return borrower;
                    })
                    .HasForeignKey(book => book.BorrowerId);

        modelBuilder.Entity<Loan>()
                    .HasMany(l => l.LoanItems)
                    .WithOne(li => li.Loan)
                    .HasForeignKey(li => li.LoanId);

        modelBuilder.Entity<LoanItem>()
                    .HasKey(li => new { li.BookId, li.LoanId });

        base.OnModelCreating(modelBuilder);
    }
}
