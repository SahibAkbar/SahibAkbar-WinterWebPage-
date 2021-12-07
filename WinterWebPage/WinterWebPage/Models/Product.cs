using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterWebPage.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string About { get; set; }

        public decimal Price { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Imagefile { get; set; }

        [ForeignKey("ProductCatagory")]
        public int ProductCatagoryId { get; set; }
        public Program ProductCatagory { get; set; }

        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        public List<Rating> Ratings { get; set; }

    }
}
