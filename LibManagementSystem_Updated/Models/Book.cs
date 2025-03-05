using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibManagementSystem_Updated.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author Name is required.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "ISBN number is required.")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "ISBN must be exactly 13 digits.")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "ISBN must be numeric and exactly 13 digits.")]
        [Index(IsUnique = true)]
        public string ISBN { get; set; }
    }
}
