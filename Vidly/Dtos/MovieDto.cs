using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public MovieDto()
        {
            Added = DateTime.Now;
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(255)]
        public string Name { get; set; }
        public GenreDto Genre { get; set; }
        [Required(ErrorMessage = "Genre Is Required")]
        public int GenreId { get; set; }
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Release date is Required")]
        public DateTime Release { get; set; }
        [Display(Name = "Added Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime Added { get; set; }
        [Required(ErrorMessage = "Stock is Required")]
        [Range(1, 20, ErrorMessage = "O estoque deve estar entre {1} e {2}")]
        public int Stock { get; set; }
    }
}