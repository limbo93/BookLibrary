using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BookLibrary.Models;

namespace BookLibrary.ViewModel
{
    public class BookFormViewModel
    {
        public IEnumerable<BookLanguage> BookLanguages { get; set; }
        public IEnumerable<BookType> BookTypes { get; set; }
        public int? Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Required]
        [StringLength(255)]
        public string Edition { get; set; }


        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }


        [Required]
        public DateTime? PublishDate { get; set; }

        [Required]
        [Range(1,100)]
        public byte? NumberInStock { get; set; }



        [Required]
        public byte? BookLanguageId { get; set; }



        [Required]
        public byte? BookTypeId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public BookFormViewModel()
        {
            Id = 0;
        }
        public BookFormViewModel(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            Edition = book.Edition;
            ISBN = book.ISBN;
            PublishDate = book.PublishDate;
            NumberInStock = book.NumberInStock;
            BookLanguageId = book.BookLanguageId;
            BookTypeId = book.BookTypeId;
        }
    }
}