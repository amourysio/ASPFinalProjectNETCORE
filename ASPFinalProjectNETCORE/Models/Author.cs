
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPFinalProjectNETCORE.Models
{

    public class Author
    {
        [Key]
        public int _Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string _ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string _FullName { get; set; }
        [Display(Name = "Biography")]
        public string _Bio { get; set; }

        public List<Book> _Books { get; set; }
    }

}
