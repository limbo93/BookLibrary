using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookLibrary.Models;
using BookLibrary.ViewModel;

namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //
        // GET: /Books/
        public ActionResult Index()
        {    
            return View();
        }


        public ActionResult New()
        {
            var bookLanguage = _context.BookLanguages.ToList();
            var bookType = _context.BookTypes.ToList();
            var viewModel = new BookFormViewModel
            {         
                BookLanguages = bookLanguage,
                BookTypes = bookType
            };
            return View("BookForm",viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel(book)
                {
                    BookLanguages = _context.BookLanguages.ToList(),
                    BookTypes = _context.BookTypes.ToList()
                };
                return View("BookForm", viewModel);
            }

            if(book.Id==0)
                _context.Books.Add(book);
            else
            {
                var bookInDb = _context.Books.Single(b => b.Id == book.Id);
                bookInDb.Name = book.Name;
                bookInDb.Edition = book.Edition;
                bookInDb.ISBN = book.ISBN;
                bookInDb.PublishDate = book.PublishDate;
                bookInDb.NumberInStock = book.NumberInStock;
                bookInDb.BookLanguageId = book.BookLanguageId;
                bookInDb.BookTypeId = book.BookTypeId;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Books");
        }

        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel(book)
            {
                BookLanguages = _context.BookLanguages.ToList(),
                BookTypes = _context.BookTypes.ToList()
            };

            return View("BookForm", viewModel);
        }
    }
}