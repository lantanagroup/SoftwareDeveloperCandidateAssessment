namespace LantanaGroup.CandidateAssessment.Server.Repositories;

public class InMemoryBookRepository : IBookRepository
{
    private static Dictionary<Guid, Book> _books;

    static InMemoryBookRepository()
    {
        List<Book> books =
        [
            new Book { Id = Guid.NewGuid(), Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Year = 1925 },
            new Book { Id = Guid.NewGuid(), Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Year = 1960 },
            new Book { Id = Guid.NewGuid(), Title = "1984", Author = "George Orwell", Genre = "Dystopian", Year = 1949 },
            new Book { Id = Guid.NewGuid(), Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Year = 1813 },
            new Book { Id = Guid.NewGuid(), Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Year = 1951 }
        ];
        _books = books.ToDictionary(book => book.Id);
    }

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
