using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutandForm.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage ="Provide FUll Name")]
        [StringLength(5,ErrorMessage ="Name should be length of 5")]
        
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
    }
}