using LantanaGroup.CandidateAssessment.Server.Models;

namespace LantanaGroup.CandidateAssessment.Server.Interfaces;

public interface IBookDatabaseRepository
{
    IEnumerable<BookModel> GetBooks();
    BookModel GetBook(Guid id);
    BookModel AddBook(BookModel book);
    BookModel UpdateBook(Guid id, BookModel book);
    void DeleteBook(Guid id);
}
