using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibManagementSystem_Updated.Models
{
    public enum Role
    {
        Student,
        Librarian
    }

    public abstract class Person
    {
        [Key]  // Primary Key
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Contact number must be exactly 10 digits.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact number must be numeric.")]
        [Index(IsUnique = true)]
        public string Contact { get; set; }

        public Role UserRole { get; set; }
    }

    public class Student : Person
    {
        [Required(ErrorMessage = "Student ID is required.")]
        public string StudentID { get; set; }

        public Student()
        {
            UserRole = Role.Student;
        }
    }

    public class Librarian : Person
    {
        [Required(ErrorMessage = "Employee ID is required.")]
        public string EmployeeID { get; set; }

        public Librarian()
        {
            UserRole = Role.Librarian;
        }
    }


    public class Book
    {
        [Key]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Author Name is required.")]
        public string Author { get; set; }



        //[Required(ErrorMessage = "ISBN number is required.")]
        [Required(ErrorMessage = "ISBN number is required.")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "ISBN must be exactly 13 digits.")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "ISBN must be numeric and exactly 13 digits.")]
        [Index(IsUnique = true)]
        public string ISBN { get; set; }


    }
}
