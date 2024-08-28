using LantanaGroup.CandidateAssessment.Server.Models;

namespace LantanaGroup.CandidateAssessment.Server.Interfaces;

public interface IBookRepository
{
    IEnumerable<Book> GetBooks();
    Book GetBook(Guid id);
    Book CreateBook(Book book);
    Book UpdateBook(Guid id, Book book);
    void DeleteBook(Guid id);
}
