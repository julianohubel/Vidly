﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Genre Is Required")]
        public int GenreId { get; set; }
        [Display(Name="Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Release date is Required")]
        public DateTime Release { get; set; }
        [Display(Name = "Added Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Added { get; set; }
        [Required(ErrorMessage = "Stock date is Required")]
        public int Stock { get; set; }


    }
    
}