using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPFinalProjectNETCORE.Models
{
    public class Publisher
    {
        [Key]
        public int _Id { get; set; }
        public string _Logo { get; set; }
        public string _Name { get; set; }

        public List<Book> _Books { get; set; }
    }
}
