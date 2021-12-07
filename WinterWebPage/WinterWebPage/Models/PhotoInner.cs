﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterWebPage.Models
{
    public class PhotoInner
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Website { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public  IFormFile Imagefile { get; set; }

    }
}
