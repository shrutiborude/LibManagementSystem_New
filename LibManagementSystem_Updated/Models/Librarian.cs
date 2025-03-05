using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace LibManagementSystem_Updated.Models
{
    public class Librarian : Person
    {
        [Required(ErrorMessage = "Employee ID is required.")]
        public string EmployeeID { get; set; }

        public Librarian()
        {
            UserRole = Role.Librarian;
        }
    }
}