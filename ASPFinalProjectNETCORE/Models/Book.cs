using ASPFinalProjectNETCORE.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ASPFinalProjectNETCORE.Models
{
    public class Book
    {
        [Key]
        public int _Id { get; set; }

        public string _BookPictureURL { get; set; }
        public string _BookName { get; set; }
        public int _Pages { get; set; }
        public string _Description { get; set; }
        public double _Price { get; set; }
        public DateTime Date { get; set; }
        public BookCategory _BookCategory { get; set; }

    }
}
