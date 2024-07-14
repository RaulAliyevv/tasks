﻿namespace EF_Projectpb201;

public class BookRepository : IBookRepository
{
    private readonly LibraryContext _context;

    public BookRepository(LibraryContext context)
    {
        _context = context;
    }

    public List<Book> GetAll()
    {
        return _context.Books.ToList();
    }

    public Book GetById(int id)
    {
        return _context.Books.Find(id);
    }

    public void Add(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Update(Book book)
    {
        _context.Books.Update(book);
        _context.SaveChanges();
    }

    public void Delete(Book book)
    {
        _context.Books.Remove(book);
        _context.SaveChanges();
    }
}