using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Required]
        [StringLength(255)]
        public string  Edition { get; set; }


        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }


        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }


        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }


        [Display(Name = "Book Language")]
        public BookLanguage BookLanguage { get; set; }
        public byte BookLanguageId { get; set; }



        [Display(Name = "Book Type")]
        public BookType BookType { get; set; }

        public byte BookTypeId { get; set; }

    }
}