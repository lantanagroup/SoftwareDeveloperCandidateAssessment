namespace LantanaGroup.CandidateAssessment.Server.Repositories;

public class InMemoryBookRepository : IBookRepository
{
    private static Dictionary<int, Book> _booksDb = new()
    {
        { 0, new Book { Id = Guid.NewGuid(), Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Year = 1925 } },
        { 1, new Book { Id = Guid.NewGuid(), Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Year = 1960 } },
        { 2, new Book { Id = Guid.NewGuid(), Title = "1984", Author = "George Orwell", Genre = "Dystopian", Year = 1949 } },
        { 3, new Book { Id = Guid.NewGuid(),  Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Year = 1813 } },
        { 4, new Book { Id = Guid.NewGuid(),  Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Year = 1951 } }
    };

    public IEnumerable<Book> GetBooks()
    {
        throw new NotImplementedException();
    }

    public Book GetBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public Book CreateBook(Book book)
    {
        throw new NotImplementedException();
    }

    public Book UpdateBook(Guid id, Book book)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }
}
