using System;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class LogUser
    {
        [Required]
        public string LUserName {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string LPassword {get;set;}
    }
}