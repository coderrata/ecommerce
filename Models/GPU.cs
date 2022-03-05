using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class GPU{

        [Key]
        public int GPUId {get;set;}

        public int BrandId {get;set;}
        [Required]
        public string GPUBrand {get;set;}
        [Required]
        public string GPUCoreCount {get;set;}
        [Required]
        public string GPUCoreClockSpeed {get;set;}
        [Required]
        public string GPUMemoryType {get;set;}
        [Required]
        public string GPUCudaCores {get;set;}
        [Required]
        public string GPUMemorySize {get;set;}
        [Required]
        public string GPUMemBandwidth {get;set;}
        [Required]
        public string GPUMBInterface {get;set;}
        [Required]
        public string GPUTDP {get;set;}
        [Required]
        public string GPUPowerConnection {get;set;}
        [Required]
        public string GPUVideoPorts {get;set;}
        [Required]
        public string GPUAPISupport {get;set;}
        [Required]
        public string GPUArchitecture {get;set;}
        [Required]
        public string GPUComputePerf {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Creator {get;set;} 
        //this is a pointer to User
        // public List<Enthusiast> EnthusiastsAdded {get;set;} 
        //many to many

    }
}