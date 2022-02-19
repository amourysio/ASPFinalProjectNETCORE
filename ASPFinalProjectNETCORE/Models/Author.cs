
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPFinalProjectNETCORE.Models
{

    public class Author
    {
        [Key]
        public int _Id { get; set; }

        public string _ProfilePictureURL { get; set; }
        public string _FullName { get; set; }
        public string _Bio { get; set; }

        public List<Book> _Books { get; set; }
    }

}
