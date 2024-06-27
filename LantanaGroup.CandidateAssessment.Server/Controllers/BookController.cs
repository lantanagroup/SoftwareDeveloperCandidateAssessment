using Microsoft.AspNetCore.Mvc;

namespace LantanaGroup.CandidateAssessment.Server.Controllers;

[ApiController]
[Route("books")]
public class BookController : ControllerBase
{
    private readonly IBookDatabaseRepository _bookDatabaseRepository;

    public BookController(IBookDatabaseRepository bookDatabaseRepository)
    {
        _bookDatabaseRepository = bookDatabaseRepository;
    }

    /// <summary>
    /// Get all books
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookModel>>> GetBooks()
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
    public async Task<ActionResult<BookModel>> GetBook(Guid id)
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
    public async Task<ActionResult<BookModel>> AddBook([FromBody] BookModel book)
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
    public async Task<ActionResult<BookModel>> UpdateBook(Guid id, [FromBody] BookModel book)
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
