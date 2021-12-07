using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterWebPage.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public  IFormFile Logofile { get; set; }

        [MaxLength(250)]
        public string Adress { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

    }
}
