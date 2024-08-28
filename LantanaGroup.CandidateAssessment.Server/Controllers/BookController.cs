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

    /// <summary>
    /// Get all books
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get a book by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Add a book
    /// </summary>
    /// <param name="book"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpPost]
    public async Task<ActionResult<Book>> AddBook([FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Update a book
    /// </summary>
    /// <param name="id"></param>
    /// <param name="book"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpPut("{id}")]
    public async Task<ActionResult<Book>> UpdateBook(Guid id, [FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete a book
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="NotImplementedException"></exception>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }
}
