using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BookLibrary.Models;

namespace BookLibrary.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Required]
        [StringLength(255)]
        public string Edition { get; set; }


        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }


        public DateTime PublishDate { get; set; }


        [Range(1, 100)]
        public byte NumberInStock { get; set; }

    }
}