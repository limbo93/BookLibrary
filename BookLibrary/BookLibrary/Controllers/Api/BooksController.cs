using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using BookLibrary.Dtos;
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
        public IHttpActionResult GetBooks()
        {
            var bookDto=_context.Books.Include(b=>b.BookLanguage).ToList().Select(Mapper.Map<Book,BookDto>);
            return Ok(bookDto);
        } 


        //GET /api/books/1
        public IHttpActionResult GetBook(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            return Ok(Mapper.Map<Book,BookDto>(book));
        }


        //POST /api/books/
        [HttpPost]
        public IHttpActionResult CreateBookeBook(BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var book = Mapper.Map<BookDto, Book>(bookDto);
            _context.Books.Add(book);
            _context.SaveChanges();

            bookDto.Id = book.Id;

            return Created(new Uri(Request.RequestUri + "/" + book.Id), bookDto);
        }


        //PUT /api/books/1
        [HttpPut]
        public IHttpActionResult UpdateBook(int id, BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var bookInDb = _context.Books.SingleOrDefault(b => b.Id == id);

            if (bookInDb == null)
                return NotFound();

            Mapper.Map(bookDto, bookInDb);

            _context.SaveChanges();
            return Ok();
        }


        //DELETE /api/books/1
        [HttpDelete]
        public IHttpActionResult DeleteBook(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(b => b.Id == id);
            if (bookInDb == null)
                return NotFound();

            _context.Books.Remove(bookInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
