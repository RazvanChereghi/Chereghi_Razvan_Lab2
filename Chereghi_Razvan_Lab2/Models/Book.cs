﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Chereghi_Razvan_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display (Name = "Book Title")]
        public string Title { get; set; }

        [ForeignKey("AuthorID")]
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        [Column (TypeName = "decimal (6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        [ForeignKey("PublisherID")]
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
    }
}
