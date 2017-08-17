﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDetailed.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage="Email Address cannot be null")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Phoneno { get; set; }

    }
}