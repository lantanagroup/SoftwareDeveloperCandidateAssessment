namespace LantanaGroup.CandidateAssessment.Server.Repositories;

public class BookDatabaseRepository : IBookDatabaseRepository
{
    private static Dictionary<int, BookModel> _booksDb = new()
    {
        { 0, new BookModel { Id = Guid.NewGuid(), Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Year = 1925 } },
        { 1, new BookModel { Id = Guid.NewGuid(), Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Year = 1960 } },
        { 2, new BookModel { Id = Guid.NewGuid(), Title = "1984", Author = "George Orwell", Genre = "Dystopian", Year = 1949 } },
        { 3, new BookModel { Id = Guid.NewGuid(),  Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Year = 1813 } },
        { 4, new BookModel { Id = Guid.NewGuid(),  Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Year = 1951 } }
    };

    public BookModel AddBook(BookModel book)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public BookModel GetBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BookModel> GetBooks()
    {
        throw new NotImplementedException();
    }

    public BookModel UpdateBook(Guid id, BookModel book)
    {
        throw new NotImplementedException();
    }
}
