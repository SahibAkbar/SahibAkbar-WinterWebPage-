using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterWebPage.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public  IFormFile MainImagefile { get; set; }


        [ForeignKey("BlogCatagory")]
        public int CatagoryId { get; set; }

        public BlogCatagory BlogCatagory { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        public List<Comment> Comments { get; set; }

        public List<TagToBlog> TagToBlogs { get; set; }


    }
}
