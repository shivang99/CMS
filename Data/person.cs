using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class person
    {
    
        [Key]
        public Guid id { get; set; }
        //add last name to the model 
        [Required(ErrorMessage = "The Last Name field is required.")]
        [StringLength(250, ErrorMessage = "Last name cannot exceed 250 characters.")]
        public string lastName { get; set; }

        //add last name to the model
        [Required(ErrorMessage = "The First Name field is required.")]
        [StringLength(250, ErrorMessage = "First name cannot exceed 250 characters.")]
        public string firstName { get; set; }

        [StringLength(15, ErrorMessage = "Phone number cannot exceed 250 characters.")]
        //add phoneNum to the model
        public String phoneNum { get; set; }

        //add dob to the model
        public DateTime birthDate { get; set; }
    }
}
