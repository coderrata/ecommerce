using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class PowerSupply{

        [Key]
        public int HobbyId {get;set;}

        public int CreatorId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        public string Description {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Creator {get;set;} 
        //this is a pointer to User
        // public List<Enthusiast> EnthusiastsAdded {get;set;} 
        //many to many

    }
}