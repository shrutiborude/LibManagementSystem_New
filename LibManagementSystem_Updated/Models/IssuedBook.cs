using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibManagementSystem_Updated.Models
{
    public class IssuedBook
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        public DateTime IssueDate { get; set; } = DateTime.Now;

        public bool IsApproved { get; set; }  // Librarian approval status
        public string RequestStatus { get; set; } 

        //public string RequestStatus { get; set; } = "Available";  // "Pending", "Approved", "Rejected"
    }
}
