using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class User{

        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
        public string LastName {get;set;}
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string UserName {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPass {get;set;}
        // public List<Enthusiast> EnthusiastUser {get;set;}
        //Activities joined by user
        // public List<Hobby> HobbiesMade {get;set;}
        //Activies made by user
    }
}