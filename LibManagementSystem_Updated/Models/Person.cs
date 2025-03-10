﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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
        [Key]
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
}
