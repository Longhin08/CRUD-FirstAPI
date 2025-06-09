using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUD_FirstAPI.Models;

namespace CRUD_FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static private List<Book> Books = new List<Book>
        {
            new Book(1, "Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 2008),
            new Book(2, "Structure and Interpretation of Computer Programs", "Harold Abelson and Gerald Jay Sussman", 1985),
            new Book(3, "Design Patterns: Elements of Reusable Object-Oriented Software", "Robert C. Martin", 1994),
            new Book(4, "The Pragmatic Programmer: From Journeyman to Master", "Andrew Hunt and David Thomas", 1999),
            new Book(5, "Introduction to Algorithms", "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest and Clifford Stein", 1990),
            
        };
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(Books);
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
               return NotFound(null);
            
            return Ok(book);
            
        }
        


    }
}
