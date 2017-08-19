using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookLibrary.Models;

namespace BookLibrary.Controllers.Api
{
    public class BooksController : ApiController
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/books
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        } 


        //GET /api/books/1
        public Book GetBook(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);
            
            if(book==null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return book;
        }


        //POST /api/books/
        [HttpPost]
        public Book CreateBookeBook(Book book)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Books.Add(book);
            _context.SaveChanges();

            return book;
        }


        //PUT /api/books/1
        [HttpPut]
        public void UpdateBook(int id,Book book)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var bookInDb = _context.Books.SingleOrDefault(b => b.Id == id);

            if (bookInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            bookInDb.Name = book.Name;
            bookInDb.Edition = book.Edition;
            bookInDb.ISBN = book.ISBN;
            bookInDb.BookLanguageId = book.BookLanguageId;
            bookInDb.BookTypeId = book.BookTypeId;
            bookInDb.NumberInStock = book.NumberInStock;
            bookInDb.PublishDate = book.PublishDate;

            _context.SaveChanges();
        }


        //DELETE /api/books/1
        [HttpDelete]
        public void DeleteBook(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(b => b.Id == id);
            if(bookInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Books.Remove(bookInDb);
            _context.SaveChanges();
        }
    }
}
