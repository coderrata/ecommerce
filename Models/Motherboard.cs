using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Motherboard{

        [Key]
        public int MotherboardId {get;set;}

        public int CPUID {get;set;}
        public int CPUBrandId {get;set;}
        public int MotherboardPrice {get;set;}
        public int MotherboardFormFactor {get;set;}
        public int MotherboardCPUSocket {get;set;}
        public int MotherboardChipSet {get;set;}
        public int MotherboardUsbPorts {get;set;}
        public int MotherboardMaxRam {get;set;}
        public int MotherboardRamChannels {get;set;}
        public int MotherboardVideoConnections {get;set;}
        public int MotherboardPCIExpressSlots {get;set;}
        public int MotherboardHasWifi {get;set;}
        public int MotherboardSataConnections {get;set;}
        public int MotherboardM2NVMESlots {get;set;}
        public int MotherboardRGBHeader {get;set;}
        public int MotherboardBrand {get;set;}
        

        [Required]
        public string Title {get;set;}
        [Required]
        public string Description {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Creator {get;set;} 
        public List<Motherboard> SearchByBrandMotherboard {get;set;} 
        public List<Motherboard> SearchByCPUIdAndMotherboard {get;set;}
       

    }
}