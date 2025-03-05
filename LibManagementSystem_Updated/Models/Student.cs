using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace LibManagementSystem_Updated.Models
{
    public class Student : Person
    {
        [Required(ErrorMessage = "Student ID is required.")]
        public string StudentID { get; set; }

        public Student()
        {
            UserRole = Role.Student;
        }
    }
}