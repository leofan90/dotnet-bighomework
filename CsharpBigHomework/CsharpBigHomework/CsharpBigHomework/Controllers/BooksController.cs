using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CsharpBigHomework.Models;
using CsharpBigHomework.Service;

namespace CsharpBigHomework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        BookService bookService;

        public BooksController(BBSContext context)
        {
            bookService = new BookService(context);
        }

        // GET: Books
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            var query = bookService.GetBooks();
            return query.ToList();
        }

        // GET: api/Books/{id}
        [HttpGet("{id}")]
        public ActionResult<Book> DetailsByBookId(string id)
        {
            var book = bookService.FindBookByBookId(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        // GET: api/Books/title/{title}
        [HttpGet("title/{title}")]
        public ActionResult<List<Book>> DetailsByBookTitle(string title)
        {
            var query = bookService.FindBookByTitle(title);
            List <Book> list = query.ToList();
            return list;
        }

        // GET: api/Books/tag/{tag}
        [HttpGet("tag/{tag}")]
        public ActionResult<List<Book>> DetailsByBookTag(string tag)
        {
            var query = bookService.FindBookByTag(tag);
            List<Book> list = query.ToList();
            return list;
        }

        // POST: api/Books
        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            try
            {
                bookService.AddBook(book);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return book;
        }

        // PUT: api/Books
        [HttpPut("{id}")]
        public ActionResult<Book> Edit(string id, Book book)
        {
            if (id != book.BookId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                bookService.ChangeBook(book);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Books/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                bookService.DeleteBook(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
