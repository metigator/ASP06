using ASP06.ControllerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP06.ControllerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // ../books
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _bookService.GetAll());
        }
    }
}