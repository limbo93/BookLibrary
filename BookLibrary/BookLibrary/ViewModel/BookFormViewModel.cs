using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookLibrary.Models;

namespace BookLibrary.ViewModel
{
    public class BookFormViewModel
    {
        public IEnumerable<BookLanguage> BookLanguages { get; set; }
        public IEnumerable<BookType> BookTypes { get; set; }
        public Book Book { get; set; }
    }
}