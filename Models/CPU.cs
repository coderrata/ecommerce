using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class CPU{

        [Key]
        public int CPUID {get;set;}

        public int CPUBrandId {get;set;}
        [Required]
        public string CPUName {get;set;}
        [Required]
        public int CPUBaseSpeed {get;set;}
        [Required]
        public int CPUMaxTurboSpeed {get;set;}
        [Required]
        public int CPUCoreCount {get;set;}
        [Required]
        public int CPUPrimaryCores {get;set;}
        [Required]
        public int CPUSecondaryCores {get;set;}
        [Required]
        public bool CPUMultiThreading {get;set;}
        [Required]
        public int CPULCache {get;set;}
        [Required]
        public string CPUMemorySupport {get;set;}
        [Required]
        public string CPUMemoryChannels {get;set;}
        [Required]
        public int CPUTDP {get;set;}
        [Required]
        public string CPUArchitecture {get;set;}
        [Required]
        public string CPUSocket {get;set;}
        [Required]
        public string CPUChipSet {get;set;}
        [Required]
        public bool CPUIntegratedGraphics {get;set;}
        [Required]
        public double CPUPrice {get;set;}




        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Creator {get;set;} 
        
        // Premade FILTER selection lists
        public List<CPU> SearchByBrand {get;set;}
        

    }
}