using Microsoft.AspNetCore.Mvc;

namespace LantanaGroup.CandidateAssessment.Server.Controllers;

[ApiController]
[Route("books")]
public class BookController : ControllerBase
{
    private readonly IBookRepository _bookRepository;

    public BookController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Book> CreateBook([FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Book> UpdateBook(Guid id, [FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }
}
