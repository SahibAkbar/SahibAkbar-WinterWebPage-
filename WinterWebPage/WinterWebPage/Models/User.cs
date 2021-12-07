using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterWebPage.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string SurName { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public  IFormFile Logofile { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(250)]
        public string Password { get; set; }

        public DateTime CretedDate { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
