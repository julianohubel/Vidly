using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        [Min18YearsOldIfMember]
        public DateTime? BirthDate { get; set; }
        public bool IsSubstribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

        [Display( Name= "Memebership Type")]
        public byte MembershipTypeId { get; set; }
    }
}