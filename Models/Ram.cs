using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Ram{

        [Key]
        public int RamID {get;set;}
        [Required]
        public double RamPrice {get;set;}
        [Required]
        public int RamMemSize {get;set;}
        [Required]
        public string RamDDRType {get;set;}
        [Required]
        public int RamFreq {get;set;}
        [Required]
        public string RamCASLatency {get;set;}
        public int RamMemBandwidth {get;set;}
        public bool RamOverClockingSupport {get;set;}
        public bool RamHeatSpreader {get;set;}
        public bool RamRGBCapable {get;set;}
        


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Creator {get;set;} 
        //this is a pointer to User
        // public List<Enthusiast> EnthusiastsAdded {get;set;} 
        //many to many

    }
}