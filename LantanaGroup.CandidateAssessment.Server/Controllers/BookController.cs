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
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<Book>> AddBook([FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Book>> UpdateBook(Guid id, [FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }
}
